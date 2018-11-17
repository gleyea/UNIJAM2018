using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour {

    [SerializeField]
    private float maxSpeed;
    private float maxPositionX;
    private float maxPositionY;
    private float minPositionX;
    private float minPositionY;
    private bool actionReady;
    private Collider2D actualCollider;
    private int collidedObject;
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


    TimeStream timeStream;

    public AudioSource audioData;
    public AudioClip audio1;
    public AudioClip audio2;
    int date = 0;

    public void Move(Vector3 nextPosition)
    {
        date = timeStream.getTime();
        Position += nextPosition * maxSpeed * Time.deltaTime;
        if (nextPosition.x != 0 || nextPosition.y != 0)
        {
           if (!audioData.isPlaying)
            {
                  if (date <= 1)
                  {
                      audioData.PlayOneShot(audio1,0.5f);
                  }
                  else 
                 audioData.PlayOneShot(audio2, 0.5f);
               // audioData.Play();
            }
        }
        else
        {
            audioData.Pause();
        }
    }

	// Use this for initialization
	void Start () {

        timeStream = TimeStream.Instance;
    }
	
    void OnTriggerEnter2D(Collider2D collider)
    {
        actionReady = true;
        actualCollider = collider;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        actionReady = false;
        actualCollider = null;
    }

    public void Action()
    {
        if (actionReady & actualCollider)
        {
            actualCollider.GetComponent<ObjectManager>().activate();
        }
 
    }
	// Update is called once per frame
	void Update () {
		
	}
}
