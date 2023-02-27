using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyLandingSound : MonoBehaviour
{
    bool canPlayJumpLandingSound;
    [SerializeField] GameObject kart;
    [SerializeField] AK.Wwise.Event landingSound;
    private void OnTriggerEnter(Collider Track)
    {
        if (!Track.CompareTag("Track")) return;
        canPlayJumpLandingSound = true;
        if (canPlayJumpLandingSound == true)
        {
            StartCoroutine(PlayLandingSound());
        }
    }
    IEnumerator PlayLandingSound()
    {
        canPlayJumpLandingSound = false;
        landingSound.Post(kart);
        yield return new WaitForSeconds(0.02f);
        canPlayJumpLandingSound = true;
    }
}
