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
        nbWood = 0;
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
        if (nbWood < 6 & GetComponent<Player>().HasWoodLog)
        {
            nbWood++;
        }
        if (nbWood == 6)
        {
            /*construction bateau*/
        }
    }
}
