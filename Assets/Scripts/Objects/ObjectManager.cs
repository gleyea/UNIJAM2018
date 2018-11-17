using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectManager: MonoBehaviour{


    //public abstract int activate();
    public abstract void activate();
    protected Collider2D player;

    protected void OnTriggerEnter2D(Collider2D collider)
    {
        player = collider;
    }

    protected void OnTriggerExit2D(Collider2D collider)
    {
        player = null;
    }
    void Start()
    {

    }


}
