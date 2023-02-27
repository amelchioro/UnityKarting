using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesWhenCollide : MonoBehaviour
{
    [SerializeField] ParticleSystem effect;
    [SerializeField] ParticleSystem effect2;
    [SerializeField] ParticleSystem effect3;
    [SerializeField] ParticleSystem effect4;
    [SerializeField] ParticleSystem effect5;
    [SerializeField] AK.Wwise.Event collision;

    void OnTriggerEnter(Collider Track)
    {
        if(!Track.CompareTag("Track")) return;
        effect.Play();
        effect2.Play();
        effect3.Play();
        effect4.Play();
        effect5.Play();
        collision.Post(gameObject);
    }
}
