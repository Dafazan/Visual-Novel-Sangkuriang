using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiobg2 : MonoBehaviour
{
    private static Audiobg2 instance;

 

    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.Play();
        }


    }

    public void StopAudio()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.Pause();
        }
    }

   
}
