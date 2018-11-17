using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCutter : MonoBehaviour {

    private int nbWoodlog = 0;
    private bool canGetWoodlog = true;
    private bool bonusState = false;
   

   

    public void incrNbWoodlog()
    {
        if (canGetWoodlog){
            nbWoodlog += 1;
            canGetWoodlog = false;
        }

    }

    public void canGetBonus()
    {
        int nbJumps = TimeStream.Instance.getTime();
        if (nbWoodlog == 2 && nbJumps == 2){
            bonusState = true;
        }
    }

    public bool getBonusState(){
        return bonusState;
    }



   


}
