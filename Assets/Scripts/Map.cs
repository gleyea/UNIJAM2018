using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    [SerializeField]
    private Sprite firstMap;
    [SerializeField]
    private Sprite secondMap;
    [SerializeField]
    private Sprite thirdMap;
    [SerializeField]
    private Sprite fourthMap;
    TimeStream timeStream;

    // Use this for initialization
    void Start () {
        timeStream = TimeStream.Instance;
    }

    // Update is called once per frame
    void Update () {
        if (timeStream.getTime() == 0)
        {
            GetComponent<SpriteRenderer>().sprite = firstMap;
        }
        if (timeStream.getTime() == 1)
        {
            GetComponent<SpriteRenderer>().sprite = secondMap;
        }
        if (timeStream.getTime() == 2)
        {
            GetComponent<SpriteRenderer>().sprite = thirdMap;
        }
        if (timeStream.getTime() == 3)
        {
            GetComponent<SpriteRenderer>().sprite = fourthMap;
        }

    }
}
