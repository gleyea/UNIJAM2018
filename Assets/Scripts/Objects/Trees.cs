using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : ObjectManager {

    [SerializeField]
    int initAge=0;

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

    // Use this for initialization
    void  Start () {

        timeStream = TimeStream.Instance;
        startDate= timeStream.getTime();
        age = initAge;
        
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        if (spriteRenderer.sprite == null)
            if (age == 0)
            {
                spriteRenderer.sprite = tree0;
            }
            else if (age==1) {
                spriteRenderer.sprite = tree1;
            }
            else if (age==2)
            {
                spriteRenderer.sprite = tree2;
            }
             else
            {
                spriteRenderer.sprite = tree3;
            }
    }
	
	// Update is called once per frame
	void Update () {

        age = timeStream.getTime() + initAge - startDate;

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
            spriteRenderer.sprite = tree2;
        }
        else if (age == 3 & spriteRenderer.sprite != tree3)
        {
            spriteRenderer.sprite = tree3;
        }
        if (age >= 4)
        {
            Destroy(gameObject);
        }
        Debug.Log(age);
    }

    public override bool activate()
    {
        if (age == 2)
        {
            age = 4;
            return true;
        }
        return false;
    }

}
