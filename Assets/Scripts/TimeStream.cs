using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStream : MonoBehaviour {

    [SerializeField]
    private int streamedTime = 0;

    public int getTime(){
        return streamedTime;
    }

    public void incrTime(){
        streamedTime += 1;
    }
}
