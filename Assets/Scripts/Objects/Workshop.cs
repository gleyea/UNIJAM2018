using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop : MonoBehaviour
{
    [SerializeField]
    Sprite workshopSprite;

    int nbWood;

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

    public void activate()
    {
        
    }
}
