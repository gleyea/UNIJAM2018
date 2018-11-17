using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int woodQuantity;
    private bool hasAxe;
    private bool hasWoodLog;
    private bool hasRaft;
    private bool onWater;

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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
