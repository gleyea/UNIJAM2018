using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStream : MonoBehaviour {
    

    private static TimeStream instance;
    private int timer;

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

    float startTime ;
    bool isVFX ;
    float VFXDuration;
    bool isEnd;

    public bool IsEnd
    {
        get
        {
            return this.isEnd;
        }
        set
        {
            this.isEnd = value;
        }
    }

    void Start()
    {
        Debug.Log("A");
        startTime = 0;
        VFXDuration = 20;
        timer = 0;
        isEnd = false;
}
    public int getTime(){
        return streamedTime;
    }

    public bool isVFXActive()
    {
        return isVFX;
    } 

    public void incrTime(){
        if (streamedTime < 3)
        {
            streamedTime += 1;
            isVFX = true;
            startTime = Time.time;
            timer = 0;
        }
    }

    private void Update()
    {
        //Debug.Log(isVFX);
        if (isVFX && timer >= VFXDuration)
        {
            //Debug.Log(isVFX);
            isVFX = false;
            startTime =0;
            timer = 0;
        }
        else if (isVFX && timer < VFXDuration)
        {
            /**animation**/
        }
        timer++;
    }
}
