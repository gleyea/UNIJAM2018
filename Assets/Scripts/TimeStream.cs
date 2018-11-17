using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStream : MonoBehaviour {

    private static TimeStream instance;

    private TimeStream(){}

    public static TimeStream Instance {
        get{
            if(instance == null){
                instance = new TimeStream();
            }
            return instance;
        }
    }

    [SerializeField]
    private static int streamedTime = 0;

    public int getTime(){
        return streamedTime;
    }

    public void incrTime(){
        streamedTime += 1;
    }
}
