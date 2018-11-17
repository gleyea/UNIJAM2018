using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River : ObjectManager
{


    [SerializeField]
    Sprite riverSprite;

    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = riverSprite;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public override int activate()
    {
        return 3;
    }
}
