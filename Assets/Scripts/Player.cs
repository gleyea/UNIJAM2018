using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int woodQuantity;
    private bool hasAxe;
    private bool hasWoodLog;
    private bool hasRaft;
    private bool onWater;
    private static Player instance;
    [SerializeField]
    Sprite playerSpriteRaft;
    [SerializeField]
    Sprite spritePlayer;
    public Animator animator;
    private bool onEarth;


    public bool OnEarth
    {
        get
        {
            return this.onEarth;
        }
        set
        {
            this.onEarth = value;
        }
    }
    public Sprite PlayerSpriteRaft
    {
        get
        {
            return this.playerSpriteRaft;
        }
        set
        {
            this.playerSpriteRaft = value;
        }
    }

    public Sprite SpritePlayer
    {
        get
        {
            return this.spritePlayer;
        }
        set
        {
            this.spritePlayer = value;
        }
    }

    private Player() { }
    public static Player Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("instance non trouvée");
            }
            return instance;
        }
    }

    private void Awake()
    {

        instance = gameObject.GetComponent<Player>();
    }

    public int WoodQuantity
    {
        get
        {
            return this.woodQuantity;
        }
        set
        {
            this.woodQuantity = value;
        }
    }

    public bool HasAxe
    {
        get
        {
            return this.hasAxe;
        }
        set
        {
            this.hasAxe = value;
        }
    }
    public bool HasWoodLog
    {
        get
        {
            return this.hasWoodLog;
        }
        set
        {
            this.hasWoodLog = value;
        }
    }
    public bool HasRaft
    {
        get
        {
            return this.hasRaft;
        }
        set
        {
            this.hasRaft = value;
        }
    }
    public bool OnWater
    {
        get
        {
            return this.onWater;
        }
        set
        {
            this.onWater = value;
        }
    }
    // Use this for initialization
    void Start () {
        woodQuantity = 0;
        hasAxe = false;
        hasWoodLog = false;
        hasRaft = false;
        animator.SetBool("hasRaft", false);
        onWater = false;
        onEarth = true;
}
	
	// Update is called once per frame
	void Update () {
        if (onEarth)
        {
            animator.SetBool("onWater", false);

            //GetComponent<SpriteRenderer>().sprite = spritePlayer;
        }
        if (!onEarth)
        {
            animator.SetBool("onWater", true);

            //GetComponent<SpriteRenderer>().sprite = playerSpriteRaft;
        }
    }
}
