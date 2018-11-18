using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCutter : ObjectManager {

    public int nbWoodlog = 0;
    private bool canGetWoodLog;
    private bool bonusState;
    int nbJumpsGift;
    int nbJumps;
    private bool stop;

    public AudioSource audioData;
    public AudioClip audio;

    public Sprite WoodCutter_0, WoodCutter_1, WoodCutter_2, WoodCutter_3;
    TimeStream timeStream;

    private void Start()
    {
        timeStream = TimeStream.Instance;
        canGetWoodLog = true;
        bonusState = false;
        nbJumpsGift = 4;
        stop = false;
    }

    public override void activate()
    {
        if (canGetWoodLog && player.GetComponent<Player>().HasWoodLog == true)
        {
            player.GetComponent<Player>().HasWoodLog = false;
            canGetWoodLog = false;
            bonusState = true;
            nbJumpsGift = timeStream.streamedTime + 1;
            audioData.PlayOneShot(audio, 1);
            
        }
    }

    private void Update()
    {
        if (player && canGetWoodLog == true)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        if (!player && transform.GetChild(2).gameObject)
        {
            transform.GetChild(2).gameObject.SetActive(false);
        }
        if (timeStream.streamedTime == 0)
        {
            GetComponent<SpriteRenderer>().sprite = WoodCutter_0;

        }
        if (timeStream.streamedTime == 1)
        {
            GetComponent<SpriteRenderer>().sprite = WoodCutter_1;

        }
        if (timeStream.streamedTime == 2)
        {
            GetComponent<SpriteRenderer>().sprite = WoodCutter_2;
        }
        if (timeStream.streamedTime == 3)
        {
            GetComponent<SpriteRenderer>().sprite = WoodCutter_3;
        }
        if (stop == false)
        {
            if (timeStream.streamedTime == 1 && nbJumpsGift == 1)
            {
                transform.GetChild(0).gameObject.GetComponent<Trees>().InitAge = 1;
                Debug.Log(transform.GetChild(0).gameObject.GetComponent<Trees>().InitAge);
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.GetComponent<Trees>().InitAge = 1;
                Debug.Log(transform.GetChild(0).gameObject.GetComponent<Trees>().InitAge);
                transform.GetChild(1).gameObject.SetActive(true);
                stop = true;
            }
            else if (timeStream.streamedTime == 2 && nbJumpsGift == 2)
            {
                transform.GetChild(0).gameObject.GetComponent<Trees>().InitAge = 0;
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.GetComponent<Trees>().InitAge = 0;
                transform.GetChild(1).gameObject.SetActive(true);
                stop = true;
            }
            else if (timeStream.streamedTime == 3 && nbJumpsGift == 3)
            {
                transform.GetChild(0).gameObject.GetComponent<Trees>().InitAge = -1;
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.GetComponent<Trees>().InitAge = -1;
                transform.GetChild(1).gameObject.SetActive(true);
                stop = true;
            }
        }
    }






}
