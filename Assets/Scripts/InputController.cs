using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    // Use this for initialization
    private Vector2 axis;

    void Move(Vector2 nextPosition)
    {

    }
	void Start () {
        axis = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        axis.x = Input.GetAxis("Horizontal");
        axis.y = Input.GetAxis("Vertical");
        Move(axis);
        if (Input.GetAxis("Action") > 0)
        {

        }
	}
}
