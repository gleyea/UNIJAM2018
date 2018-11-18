using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : ObjectManager {

    public Sprite Friend_0, Friend_1, Friend_2, Friend_3;
    TimeStream timeStream;
    private int end;

    // Use this for initialization
    void Start () {
        timeStream = TimeStream.Instance;
    }
	
	// Update is called once per frame
	void Update () {
        if (player && timeStream.streamedTime <= 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (player && timeStream.streamedTime == 2)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (!player || timeStream.streamedTime == 3)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
        }
        int nbJumps = timeStream.getTime();
        if (nbJumps == 0){
            this.GetComponent<SpriteRenderer>().sprite = Friend_0;
        }
        else if (nbJumps == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = Friend_1;
        }
        else if (nbJumps == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = Friend_2;
        }
        else if (nbJumps == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = Friend_3;
        }
    }
    public override void activate()
    {/**
        Debug.Log("BONJOUR");
        if (player)
        {
            Debug.Log(player);
            end = timeStream.streamedTime;
            switch (end)
            {
                case 0:
                    player.transform.GetChild(1).gameObject.SetActive(true);
                    break;
                case 1:
                    player.transform.GetChild(2).gameObject.SetActive(true);
                    break;
                case 2:
                    player.transform.GetChild(3).gameObject.SetActive(true);
                    break;
                case 3:
                    player.transform.GetChild(4).gameObject.SetActive(true);
                    break;
            }
        }**/
    }
}
