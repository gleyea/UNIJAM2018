using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXSound : MonoBehaviour {


    TimeStream timeStream;
    public GameObject go;

    public AudioSource audioData;
    bool audioPause;

    // Use this for initialization
    void Start () {
        timeStream = TimeStream.Instance;
         audioPause = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (timeStream.isVFXActive() /*& !audioPause*/)
        {
            go.SetActive(true);
            if (audioPause || !audioData.isPlaying)
            {
                audioData.Play();
            }
            audioPause = false;
        }
        else if (!timeStream.isVFXActive())
        {
            go.SetActive(false);
            audioPause = true;
            audioData.Pause();
        }
       
    }
}
