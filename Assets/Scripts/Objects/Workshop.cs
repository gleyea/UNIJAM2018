using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop : ObjectManager
{
    

    int nbWood;



    [SerializeField]
    Sprite atelier0;

    [SerializeField]
    Sprite atelier1;

    [SerializeField]
    Sprite atelier2;

    [SerializeField]
    Sprite atelier3;

    [SerializeField]
    Sprite atelier4;

    [SerializeField]
    Sprite atelier5;

    private SpriteRenderer spriteRenderer;



    public AudioSource audioData;
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audioConstruction1;
    public AudioClip audioConstruction2;

    TimeStream timeStream;

    // Use this for initialization
    void Start()
    {
        timeStream = TimeStream.Instance;
        nbWood = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = atelier0;
    }

    // Update is called once per frame
    void Update()
    {
        if (nbWood == 0 & spriteRenderer.sprite != atelier0)
        {
            spriteRenderer.sprite = atelier0;
        }
        else if (nbWood == 1 & spriteRenderer.sprite != atelier1)
        {
            spriteRenderer.sprite = atelier1;
        }
        else if (nbWood == 2 & spriteRenderer.sprite != atelier2)
        {
            spriteRenderer.sprite = atelier2;
        }
        else if (nbWood == 3 & spriteRenderer.sprite != atelier3)
        {
            spriteRenderer.sprite = atelier3;
        }
        else if (nbWood == 4 & spriteRenderer.sprite != atelier4)
        {
            spriteRenderer.sprite = atelier4;
        }
        else if (nbWood == 5 & spriteRenderer.sprite != atelier5)
        {
            spriteRenderer.sprite = atelier5;
        }
    }

    public override void activate()
    {
        if (nbWood == 5)
        {
            nbWood = 0;
            player.gameObject.GetComponent<Player>().HasRaft = true;
            GameObject.Find("river").GetComponent<PolygonCollider2D>().isTrigger = true;
        }
        if (nbWood < 5 & player.gameObject.GetComponent<Player>().HasWoodLog)
        {
            nbWood++;
            player.gameObject.GetComponent<Player>().HasWoodLog = false;
            if (nbWood == 5)
            {
                if (timeStream.getTime() <= 2)
                {
                    audioData.PlayOneShot(audioConstruction1, 1);
                }
                else
                {
                    audioData.PlayOneShot(audioConstruction2, 1);
                }

            }
            else
            {
                if (timeStream.getTime() <= 2)
                {
                    audioData.PlayOneShot(audio1, 1);
                }
                else
                {
                    audioData.PlayOneShot(audio2, 1);
                }
            }
            
        }
      
    }
}
