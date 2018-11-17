using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : ObjectManager
{


    [SerializeField]
    Sprite axeSprite;

    bool isActivated;
    
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        isActivated = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = axeSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivated)
        {
            Destroy(gameObject);
        }
    }

    public override bool activate()
    {
        isActivated = true;
        return true;
    }
}
