using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windScript : MonoBehaviour {


    TimeStream timeStream;
    public AudioSource audioData;
    bool audioPause;

    // Use this for initialization
    void Start () {
        timeStream = TimeStream.Instance;
        audioPause = false;
    }
	
	// Update is called once per frame
	void Update () {
        if ((timeStream.isVFXActive() || timeStream.IsEnd) & !audioPause )
        {
            audioData.Pause();
            audioPause = true;
        }
        else if (audioPause & (!timeStream.isVFXActive() & !timeStream.IsEnd))
        {
            audioPause = false;
            audioData.Play();
        }
        if (!timeStream.isVFXActive() & !timeStream.IsEnd)
        {

            if (!audioData.isPlaying & timeStream.getTime() <= 2)
            {
                audioData.Play();
            }
        }
    }
}
