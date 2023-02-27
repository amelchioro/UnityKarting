using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTriggerBillboardPassby : MonoBehaviour
{
    [SerializeField] AK.Wwise.Event passByEvent;
    [SerializeField] GameObject billboardGameObject;
    [SerializeField] GameObject triggerObject;
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == triggerObject)
        {
            passByEvent.Post(billboardGameObject);
        }
    }
}
