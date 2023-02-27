using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollectSoundCheckpoint : MonoBehaviour
{
    public AK.Wwise.Event CheckpointSoundEvent;
    public void OnTriggerEnter()
    {
        CheckpointSoundEvent.Post(gameObject);     
    }
 
}
