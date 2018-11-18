using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class riverAnimals : MonoBehaviour {




    TimeStream timeStream;
    public AudioSource audioData;
    public AudioClip audio;

    bool audioPause;

    // Use this for initialization
    void Start()
    {
        audioPause = false;
        timeStream = TimeStream.Instance;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStream.isVFXActive() & !audioPause)
        {
            audioData.Pause();
            audioPause = true;
        }
        else if (audioPause & !timeStream.isVFXActive())
        {
            audioPause = false;
            audioData.PlayOneShot(audio, 1);
            // audioData.Play();
        }
        if (!timeStream.isVFXActive())
        {

            if (!audioData.isPlaying & timeStream.getTime() <= 2)
            {
                audioData.PlayOneShot(audio, 1);
                //audioData.Play();
            }
        }
    }



}
