using KartGame.Track;
using System.Collections;
using UnityEngine;

public class MyObjectiveCompleteLaps : Objective
{

    [Tooltip("How many laps should the player complete before the game is over?")]
    public int lapsToComplete;

    [Header("Notification")]
    [Tooltip("Start sending notification about remaining laps when this amount of laps is left")]
    public int notificationLapsRemainingThreshold = 1;



    public int currentLap { get; private set; }

    void Awake()
    {
        currentLap = 0;

        // set a title and description specific for this type of objective, if it hasn't one
        if (string.IsNullOrEmpty(title))
            title = $"Complete {lapsToComplete} {targetName}s";

    }

    IEnumerator Start()
    {
        TimeManager.OnSetTime(totalTimeInSecs, isTimed, gameMode);
        TimeDisplay.OnSetLaps(lapsToComplete);
        yield return new WaitForEndOfFrame();
        Register();
    }


    //Wwise
    [SerializeField] AK.Wwise.Event lastLap;
    [SerializeField] AK.Wwise.Event lapCompleted;
    [SerializeField] AK.Wwise.Event finished;

    
    protected override void ReachCheckpoint(int remaining)
    {
        if (isCompleted)
            return;

        currentLap++;


        int targetRemaining = lapsToComplete - currentLap;

        // update the objective text according to how many enemies remain to kill
        if (targetRemaining == 0)
        {
            CompleteObjective(string.Empty, GetUpdatedCounterAmount(),
                "Objective complete: " + title);

            finished.Post(gameObject);
        }
        else if (targetRemaining == 1)
        {
            string notificationText = notificationLapsRemainingThreshold >= targetRemaining
                ? "One " + targetName + " left"
                : string.Empty;
            UpdateObjective(string.Empty, GetUpdatedCounterAmount(), notificationText);

            lastLap.Post(gameObject);
            lapCompleted.Post(gameObject);
        }
        else if (targetRemaining > 1)
        {
            // create a notification text if needed, if it stays empty, the notification will not be created
            string notificationText = notificationLapsRemainingThreshold >= targetRemaining
                ? targetRemaining + " " + targetName + "s to collect left"
                : string.Empty;

            UpdateObjective(string.Empty, GetUpdatedCounterAmount(), notificationText);

            lapCompleted.Post(gameObject);
        }

    }

    public override string GetUpdatedCounterAmount()
    {
        return currentLap + " / " + lapsToComplete;
    }





}
