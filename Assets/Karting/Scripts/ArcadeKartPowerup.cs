using KartGame.KartSystems;
using UnityEngine;
using UnityEngine.Events;

public class ArcadeKartPowerup : MonoBehaviour {

    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        MaxTime = 5
    };

    public bool isCoolingDown { get; private set; }
    public float lastActivatedTimestamp { get; private set; }

    public float cooldown = 5f;

    public bool disableGameObjectWhenActivated;
    public UnityEvent onPowerupActivated;
    public UnityEvent onPowerupFinishCooldown;

    private void Awake()
    {
        lastActivatedTimestamp = -9999f;
    }


    private void Update()
    {
        if (isCoolingDown) { 

            if (Time.time - lastActivatedTimestamp > cooldown) {
                //finished cooldown!
                isCoolingDown = false;
                boostStats.ElapsedTime = 0f;
                onPowerupFinishCooldown.Invoke();
            }

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;
        if (isCoolingDown)
        {
            Debug.Log("I'm on Cooldown");
            return;
        }

        var rb = other.attachedRigidbody;
        if (rb) {
            Debug.Log("Found RB");
            var kart = rb.GetComponent<ArcadeKart>();

            if (kart)
            {
                Debug.Log("FOund Kart");
                lastActivatedTimestamp = Time.time;
                kart.AddPowerup(this.boostStats);
                onPowerupActivated.Invoke();
                isCoolingDown = true;

                if (disableGameObjectWhenActivated) this.gameObject.SetActive(false);
            }
        }
    }

}
