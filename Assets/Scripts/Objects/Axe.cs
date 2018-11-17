using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : ObjectManager
{


    [SerializeField]
    Sprite axeSprite1;

    [SerializeField]
    Sprite axeSprite2;

    bool isActivated;
    
    private SpriteRenderer spriteRenderer;



    // Use this for initialization
    void Start()
    {
        isActivated = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = axeSprite1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivated)
        {
            spriteRenderer.sprite = axeSprite2;
        }
    }

    public override void activate()
    {
        if (!isActivated)
        {
            isActivated = true;
            player.gameObject.GetComponent<Player>().HasAxe = true;
            //character.GetComponent<Player>().HasAxe = true;
        }
    }
}
