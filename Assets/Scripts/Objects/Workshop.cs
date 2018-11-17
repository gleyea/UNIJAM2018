using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop : ObjectManager
{
    [SerializeField]
    Sprite workshopSprite;
    

    int nbWood;

    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        nbWood = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = workshopSprite;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public override void activate()
    {
        if (nbWood < 6 & GetComponent<Player>().HasWoodLog)
        {
            nbWood++;
            GetComponent<Player>().HasWoodLog = false;
        }
        if (nbWood == 6)
        {
            /*
             * 
             * 
             * construction bateau
             * 
             * 
             * 
             *         
             */
        }
    }
}
