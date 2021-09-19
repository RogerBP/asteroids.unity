using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiontEfectBehavior : MonoBehaviour
{
    public AudioSource audiosource;
    public ParticleSystem particles;
    void Start()
    {
        particles.Play(false);
        audiosource.Play();
        Destroy(gameObject, 1.0f);
    }
}
