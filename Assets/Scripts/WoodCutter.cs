using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCutter : MonoBehaviour {

    public int nbWoodlog = 0;
    private bool canGetWoodlog = true;
    private bool bonusState = false;

    TimeStream timeStream;

    private void Start()
    {
        timeStream = TimeStream.Instance;
    }

    public void incrNbWoodlog()
    {
        if (canGetWoodlog){
            nbWoodlog += 1;
            canGetWoodlog = false;
        }

    }

    public void canGetBonus()
    {
        int nbJumps = timeStream.getTime();

        //Debug.Log(nbJumps);

        if (nbWoodlog == 2 && nbJumps == 2){
            bonusState = true;
        }
        else{
            bonusState = false;
        }
    }

    public bool getBonusState(){
        return bonusState;
        
    }

    private void Update()
    {
        Debug.Log(bonusState);
        canGetBonus();
    }






}
