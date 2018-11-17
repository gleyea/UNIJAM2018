using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Object : MonoBehaviour {

    // Use this for initialization
    protected abstract void Start();
	
	// Update is called once per frame
	protected abstract void Update();

    public abstract void activate();

}
