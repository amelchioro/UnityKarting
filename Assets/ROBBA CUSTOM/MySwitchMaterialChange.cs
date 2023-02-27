using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySwitchMaterialChange : MonoBehaviour
{
[SerializeField] AK.Wwise.Switch enterSwitch;
[SerializeField] AK.Wwise.Switch exitSwitch;
[SerializeField] Collider colliderSwitch;
[SerializeField] Collider colliderSwitch2;

    void OnTriggerEnter (Collider other)
    {
        if (other == colliderSwitch || other == colliderSwitch2)
        {
            enterSwitch.SetValue(gameObject);
        }
    }
    void OnTriggerExit (Collider other)
    {
        if (other == colliderSwitch || other == colliderSwitch2)
        {
            exitSwitch.SetValue(gameObject);
        }  
    }
}
