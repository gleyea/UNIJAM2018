using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River : MonoBehaviour
{

    [SerializeField]
    Sprite riverSprite;

    private SpriteRenderer spriteRenderer;


    TimeStream timeStream;
    public AudioSource audioData;
    public AudioClip audio;

    // Use this for initialization
    void Start()
    {
        timeStream = TimeStream.Instance;

        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = riverSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioData.isPlaying & timeStream.getTime() <= 2)
        {
            audioData.PlayOneShot(audio, 1);
        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            //Debug.Log("onWater");
            if (collider.gameObject.GetComponent<Player>().HasRaft)
            {
                Debug.Log("onWater");
                collider.gameObject.GetComponent<Player>().OnEarth = false;
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            //Debug.Log("onEarth");
            if (collider.gameObject.GetComponent<Player>().HasRaft)
            {
                Debug.Log("onEarth");
                collider.gameObject.GetComponent<Player>().OnEarth = true;
             }
         }
    }

 
}
