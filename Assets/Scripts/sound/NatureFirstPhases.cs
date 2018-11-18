using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureFirstPhases : MonoBehaviour
{

    //public AudioSource audioSource;
    AudioSource audioData;

    TimeStream timeStream;
    int date;

    // Use this for initialization
    void Start()
    {
        timeStream = TimeStream.Instance;
        date = timeStream.getTime();

        audioData = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        date = timeStream.getTime();
        if (timeStream.isVFXActive() || timeStream.IsEnd)
        {
            audioData.Stop();
        }
        else {
            if (date < 3 & !audioData.isPlaying)
            {
                audioData.Play();
            }
            else if (date >= 3)
            {
                audioData.Stop();
            }
        }
    }
}
