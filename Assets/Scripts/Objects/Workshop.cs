using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop : ObjectManager
{
    [SerializeField]
    Sprite workshopSprite;

    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = workshopSprite;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public override bool activate()
    {
        return true;
    }
}
