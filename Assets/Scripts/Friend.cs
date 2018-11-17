using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour {

    public Sprite Friend_0, Friend_1, Friend_2;
    TimeStream timeStream;

    // Use this for initialization
    void Start () {
        timeStream = TimeStream.Instance;
    }
	
	// Update is called once per frame
	void Update () {
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
    }
}
