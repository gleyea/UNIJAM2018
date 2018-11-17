using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStream : MonoBehaviour {

    private static TimeStream instance;

    private TimeStream(){}

    public static TimeStream Instance {
        get{
            if(instance == null){
                Debug.LogError("instance non trouvée");
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = gameObject.GetComponent<TimeStream>();
    }
    [SerializeField]
    public int streamedTime;

    void Start()
    {
        Debug.Log("B");
    }
    public int getTime(){
        return streamedTime;
    }

    public void incrTime(){
        if (streamedTime < 3)
        {
            streamedTime += 1;
        }
    }
}
