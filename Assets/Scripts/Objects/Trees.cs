using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : ObjectManager {

    [SerializeField]
    int age;




    [SerializeField]
    Sprite tree1;

    [SerializeField]
    Sprite tree2;

    private SpriteRenderer spriteRenderer;


    
    // Use this for initialization
    void  Start () {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        if (spriteRenderer.sprite == null)
            if (age == 1)
            {
                spriteRenderer.sprite = tree1;
            }
            else
            {
                spriteRenderer.sprite = tree2;
            }
    }
	
	// Update is called once per frame
	void Update () {
		if (age == 1 & spriteRenderer.sprite != tree1)
        {
            spriteRenderer.sprite = tree1;
        }
        else if (age == 2 & spriteRenderer.sprite != tree2)
        {
            spriteRenderer.sprite = tree2;
        }
        if (age == 5)
        {
            Destroy(gameObject);
        }
    }

    public override bool activate()
    {
        if (age == 3)
        {
            age = 5;
            return true;
        }
        return false;
    }

}
