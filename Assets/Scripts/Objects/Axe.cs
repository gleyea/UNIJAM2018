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

    TimeStream timeStream;
    public AudioSource audioData;
    public AudioClip audio1;
    public AudioClip audio2;

    // Use this for initialization
    void Start()
    {
        timeStream = TimeStream.Instance;
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
            if (timeStream.getTime() <= 2)
            {
                audioData.PlayOneShot(audio1, 1);
            }
            else
            {
                audioData.PlayOneShot(audio2, 1);
            }
            isActivated = true;
            player.gameObject.GetComponent<Player>().HasAxe = true;
            //character.GetComponent<Player>().HasAxe = true;
        }
    }
}
