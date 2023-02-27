using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class MyTriggerBoostSound : MonoBehaviour
{

    public GameObject triggerBody;
    public GameObject ciaone;
    public AK.Wwise.Event triggerEvent;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == triggerBody)
        {
            triggerEvent.Post(ciaone);
        }
    }

}
