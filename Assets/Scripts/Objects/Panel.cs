using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : ObjectManager {

    TimeStream timeStream;

    // Use this for initialization
    void Start () {
        timeStream = TimeStream.Instance;
    }

    public override void activate()
    {

     }
    // Update is called once per frame
    void Update () {
		if (player)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (!player)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
