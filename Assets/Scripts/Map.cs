using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

   
    TimeStream timeStream;
    public Animator animator;

    // Use this for initialization
    void Start () {
        timeStream = TimeStream.Instance;
    }

    // Update is called once per frame
    void Update () {
        int SpendedTime = timeStream.getTime();
        animator.SetInteger("nbJumps", SpendedTime);

    }
}
