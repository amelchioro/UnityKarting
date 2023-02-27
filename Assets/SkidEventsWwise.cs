using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;


namespace KartGame.KartSystems
{
    public class SkidEventsWwise : MonoBehaviour
    {
        //Mia Parte per l'implementazione dell'evento di Drift di Wwise
        public AK.Wwise.Event skidStart;
        public AK.Wwise.State skidOn;
        public AK.Wwise.State skidOff;

        ArcadeKart arcadeKart;

        void Awake()
        {
            arcadeKart = GetComponentInParent<ArcadeKart>();
        }
        void Start()
        {
            skidStart.Post(gameObject);
        }

        void Update()
        {
            if (arcadeKart.IsDrifting == true)
            {
                skidOn.SetValue();
            }

            else
            {
                skidOff.SetValue();
            }
        }

    }
}