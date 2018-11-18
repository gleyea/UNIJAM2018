using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : ObjectManager {

    private int end;
    private float timer;
    private float maxTimer;
    private bool credit;
    TimeStream timeStream;

    public AudioSource audioData;

    public AudioClip end0;
    public AudioClip end1;
    public AudioClip end2;
    public AudioClip end3;

    // Use this for initialization
    void Start () {
        timeStream = TimeStream.Instance;
        timer = 0;
        maxTimer = 4;
        credit = false;
    }

    public override void activate()
    {
        Debug.Log("BONJOUR");
        if (player)
        {
            Debug.Log(player);
            end = timeStream.streamedTime;
            switch (end)
            {
                case 0:
                    player.transform.GetChild(1).gameObject.SetActive(true);
                    timeStream.IsEnd = true;
                    credit = true;
                    audioData.PlayOneShot(end0, 1);
                    break;
                case 1:
                    player.transform.GetChild(2).gameObject.SetActive(true);
                    timeStream.IsEnd = true;
                    credit = true;
                    audioData.PlayOneShot(end1, 0.8f);
                    break;
                case 2:
                    player.transform.GetChild(3).gameObject.SetActive(true);
                    timeStream.IsEnd = true;
                    credit = true;
                    audioData.PlayOneShot(end2, 1);
                    break;
                case 3:
                    player.transform.GetChild(4).gameObject.SetActive(true);
                    timeStream.IsEnd = true;
                    credit = true;
                    audioData.PlayOneShot(end3, 1);
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update () {
        if (credit)
        {
            timer += Time.deltaTime;
            if (timer >= maxTimer)
            {
                SceneManager.LoadScene("CreditScene");
            }
        }
		
	}
}
