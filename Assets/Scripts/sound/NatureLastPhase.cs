﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureLastPhase : MonoBehaviour
{

    //public AudioSource audioSource;
    AudioSource audioData;

    TimeStream timeStream;
    int date;
    bool isPlaying;


    // Use this for initialization
    void Start()
    {
        timeStream = TimeStream.Instance;
        date = timeStream.getTime();

        audioData = GetComponent<AudioSource>();
        isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        date = timeStream.getTime();
        if (date >= 3 & !isPlaying)
        {
            audioData.Play();
            isPlaying = true;
        }
        else if (date <= 2)
        {
            audioData.Stop();
        }
    }
}
