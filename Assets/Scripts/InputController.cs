using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    // Use this for initialization
    public Animator animator;
    private Vector2 axis;
    TimeStream timeStream;

    public Vector3 Axis
    {
        get
        {
            return this.axis;
        }
        set
        {
            this.axis = value;
        }
    }

	void Start () {
        axis = new Vector3(0, 0, 0);
        timeStream = TimeStream.Instance;
    }

    // Update is called once per frame
    void Update () {
        if (!timeStream.isVFXActive())
        {
            axis.x = Input.GetAxis("Horizontal");
            axis.y = Input.GetAxis("Vertical");
            GetComponent<Engine>().Move(axis);
            if (Input.GetButtonDown("Action"))
            {
                GetComponent<Engine>().Action();
            }
            if (Input.GetButtonDown("TimeTravel"))
            {
                timeStream.incrTime();
            }

            animator.SetFloat("SpeedX", axis.x);
            animator.SetFloat("SpeedY", axis.y);
        }
    }
}
