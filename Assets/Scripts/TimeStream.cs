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

    float startTime ;
    bool isVFX ;
    float VFXDuration;

    void Start()
    {
        float startTime = 0;
        bool isVFX = false;
        VFXDuration = 1;
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
        }
    }

    private void Update()
    {
        if (isVFX & Time.time - startTime >= VFXDuration)
        {
            isVFX = false;
            startTime =0;
        }
        else if (isVFX & Time.time - startTime < VFXDuration)
        {
            /**animation**/
            Debug.Log(Time.time - startTime);
        }
    }
}
