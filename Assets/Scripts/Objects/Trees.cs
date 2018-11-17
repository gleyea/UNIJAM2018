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
    Sprite tree3;

    private SpriteRenderer spriteRenderer;

    TimeStream timeStream;

    [SerializeField]
    private float positionY;

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
    void  Start () {

        timeStream = TimeStream.Instance;
        startDate= timeStream.getTime();
        age = initAge;
        
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
        }
        else if (age == 1 & spriteRenderer.sprite != tree1)
        {
            spriteRenderer.sprite = tree1;
        }
        else if (age == 2 & spriteRenderer.sprite != tree2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + positionY, transform.position.z);
            spriteRenderer.sprite = tree2;
        }
        else if (age == 3 & spriteRenderer.sprite != tree3)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - positionY, transform.position.z);

            spriteRenderer.sprite = tree3;
        }
        if (age >= 4)
        {
            Destroy(gameObject);
        }
        //Debug.Log(age);
    }

    public override void activate()
    {
        if (age == 2 & player.gameObject.GetComponent<Player>().HasAxe & !player.gameObject.GetComponent<Player>().HasWoodLog )
        {
            initAge +=1 ;
            player.gameObject.GetComponent<Player>().HasWoodLog = true;
            age = 3;
        }
    }

}
