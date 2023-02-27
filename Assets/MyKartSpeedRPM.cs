using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyKartSpeedRPM : MonoBehaviour
{
    public AK.Wwise.RTPC Speed;
    public AK.Wwise.RTPC RPM;
    public AK.Wwise.RTPC verticalSpeed;
    public AK.Wwise.Switch reverseGearOn;
    public AK.Wwise.Switch reverseGearOff;
    KartGame.KartSystems.ArcadeKart arcadeKart;
    Rigidbody rb;

    void Awake()
    {
        arcadeKart = GetComponent<KartGame.KartSystems.ArcadeKart>();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float kartSpeed = arcadeKart != null ? arcadeKart.LocalSpeed() : 0;
        float effectiveSpeed = kartSpeed;

        Speed.SetValue(this.gameObject, effectiveSpeed * 100);
        verticalSpeed.SetValue(gameObject, rb.velocity.y * -1);

        if(kartSpeed < 0)
        {
            effectiveSpeed = effectiveSpeed * -1;
            RPM.SetValue(this.gameObject, effectiveSpeed * 700 + 700);
            reverseGearOn.SetValue(this.gameObject);
        }
        else
        {
            reverseGearOff.SetValue(this.gameObject);
            RPM.SetValue(this.gameObject, effectiveSpeed * 2300 + 700);
        }

    }
}
