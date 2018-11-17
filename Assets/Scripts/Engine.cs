﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour {

    [SerializeField]
    private float maxSpeed;
    private float maxPositionX;
    private float maxPositionY;
    private float minPositionX;
    private float minPositionY;
    public Vector3 Position
    {
        get
        {
            return transform.position;
        }
        set
        {
            transform.position = value;
        }
    }

    public float MaxPositionX
    {
        get
        {
            return this.maxPositionX;
        }
        set
        {
            this.maxPositionX = value;
        }
    }

    public float MaxPositionY
    {
        get
        {
            return this.maxPositionY;
        }
        set
        {
            this.maxPositionY = value;
        }
    }

    public float MinPositionX
    {
        get
        {
            return this.minPositionX;
        }
        set
        {
            this.minPositionX = value;
        }
    }

    public float MinPositionY
    {
        get
        {
            return this.minPositionY;
        }
        set
        {
            this.minPositionY = value;
        }
    }
    public void Move(Vector3 nextPosition)
    {
        Position += nextPosition * maxSpeed * Time.deltaTime;
    }

    public void Action()
    {

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
