using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureFirstPhases : MonoBehaviour
{

    //public AudioSource audioSource;
    AudioSource audioData;

    TimeStream timeStream;
    int date;
    bool isPlaying;

    // Use this for initialization
    void Start()
    {
        isPlaying = false;
        timeStream = TimeStream.Instance;
        date = timeStream.getTime();

        audioData = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (date < 3 & !isPlaying )
        {
            audioData.Play();
            isPlaying = true;
        }
        else if (date >= 3)
        {
            audioData.Stop();
        }
    }
}
