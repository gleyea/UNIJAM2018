using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : ObjectManager {

    [SerializeField]
    private int initAge=0;

    int startDate;

    int age;

    [SerializeField]
    Sprite tree0;

    [SerializeField]
    Sprite tree1;

    [SerializeField]
    Sprite tree2;

    [SerializeField]
    Sprite tree2bis;

    [SerializeField]
    Sprite tree3;

    private SpriteRenderer spriteRenderer;

    TimeStream timeStream;

    [SerializeField]
    private float positionY;
    
    public AudioSource audioData;
    public AudioClip audio1;
    public AudioClip audio2;


    int nbCoups ;

    public int InitAge
    {
        get
        {
            return this.initAge;
        }
        set
        {
            this.initAge = value;
        }
    }

    public Sprite Tree2
    {
        get
        {
            return this.tree2;
        }
        set
        {
            this.tree2 = value;
        }
    }
    // Use this for initialization
    void Start () {

        timeStream = TimeStream.Instance;
        startDate= timeStream.getTime();
        age = initAge;
        nbCoups = 0;
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {

            if (age == 0)
            {
                spriteRenderer.sprite = tree0;
            }
            else if (age == 1)
            {
                spriteRenderer.sprite = tree1;
            }
            else if (age == 2)
            {
                spriteRenderer.sprite = tree2;
            }
            else
            {
                spriteRenderer.sprite = tree3;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {

        age = initAge + timeStream.getTime();

    	if (age == 0 & spriteRenderer.sprite != tree0)
        {
            spriteRenderer.sprite = tree0;
            transform.GetChild(0).gameObject.SetActive(false);
            Destroy(GetComponent<PolygonCollider2D>());
            gameObject.AddComponent<PolygonCollider2D>();
        }
        else if (age == 1 & spriteRenderer.sprite != tree1)
        {
            spriteRenderer.sprite = tree1;
            transform.GetChild(0).gameObject.SetActive(false);
            Destroy(GetComponent<PolygonCollider2D>());
            gameObject.AddComponent<PolygonCollider2D>();
        }
        else if (age == 2)
        {
            if (spriteRenderer.sprite != tree2 & spriteRenderer.sprite != tree2bis)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + positionY, transform.position.z);
                transform.GetChild(0).gameObject.SetActive(true);
            }
            if (nbCoups == 0 & spriteRenderer.sprite != tree2)
            {
                spriteRenderer.sprite = tree2;

                Debug.Log(nbCoups);
            }
            else if (nbCoups!=0 & spriteRenderer.sprite != tree2bis)
            {
                spriteRenderer.sprite = tree2bis;
                spriteRenderer.transform.localScale -= new Vector3(0f, 0.02f, 0);
                transform.GetChild(0).transform.localScale+=new Vector3(0.1f, 0.1f, 0);
                Destroy(GetComponent<PolygonCollider2D>());
                gameObject.AddComponent<PolygonCollider2D>();
            }
        }
        else if (age == 3 & spriteRenderer.sprite != tree3)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - positionY, transform.position.z);
            transform.GetChild(0).gameObject.SetActive(false);
            spriteRenderer.sprite = tree3;
            Destroy(GetComponent<PolygonCollider2D>());
            gameObject.AddComponent<PolygonCollider2D>();
        }
        if (age >= 4)
        {
            Destroy(gameObject);
        }
    }

    public override void activate()
    {
        if (age == 2 & player.gameObject.GetComponent<Player>().HasAxe & !player.gameObject.GetComponent<Player>().HasWoodLog )
        {
            if (timeStream.getTime() <= 2)
            {
                audioData.PlayOneShot(audio1, 1);
            }
            else
            {
                audioData.PlayOneShot(audio2, 1);
            }
            if (nbCoups == 0)
            {
                nbCoups++;
                gameObject.transform.localScale-=new Vector3(0.9f,0.8f,0);
            }
            else
            {
                initAge += 1;
                player.gameObject.GetComponent<Player>().HasWoodLog = true;
                age = 3;
            }
        }
    }

}
