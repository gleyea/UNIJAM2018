using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : ObjectManager {

    private int end;
	// Use this for initialization
	void Start () {
		
	}

    public override void activate()
    {
        end = GetComponent<TimeStream>().streamedTime;
        switch(end)
        {
            case 0:
                
                break;
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
