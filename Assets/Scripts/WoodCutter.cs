using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCutter : MonoBehaviour {

    public int nbWoodlog = 0;
    private bool canGetWoodlog = true;
    private bool bonusState = false;
    int nbJumps;

    public Sprite WoodCutter_0, WoodCutter_1, WoodCutter_2, WoodCutter_3;
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

        nbJumps = timeStream.getTime();
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
        int nbJumps = timeStream.getTime();
        if (nbJumps == 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = WoodCutter_0;
        }
        else if (nbJumps == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = WoodCutter_1;
        }
        else if (nbJumps == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = WoodCutter_2;
        }
        else if (nbJumps == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = WoodCutter_3;
        }
    }






}
