using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour {

    private Vector2 direction;
    [SerializeField]
    private Vector2 size;
    private Vector2 positionRay;
    private RaycastHit2D hit;
    private bool onHitX;
    private bool onHitY;

    public bool OnHitX
    {
        get
        {
            return this.onHitX;
        }
        set
        {
            this.onHitX = value;
        }
    }

    public bool OnHitY
    {
        get
        {
            return this.onHitY;
        }
        set
        {
            this.onHitY = value;
        }
    }
    void Start()
    {
        onHitX = false;
        onHitY = false;
    }

    //Fonction qui crée les Ray2D autout du joueur pour les collisions
    void PlayerRaycast()
    {
        if (GetComponent<InputController>().Axis.x > 0 )
        {
            direction.x = 1;
        }
        if (GetComponent<InputController>().Axis.x < 0)
        {
            direction.x = -1;
        }
        if (GetComponent<InputController>().Axis.y > 0)
        {
            direction.y = 1;
        }
        if (GetComponent<InputController>().Axis.y < 0)
        {
            direction.y = -1;
        }
        if (direction.x != 0)
        {
            for (float i = -1; i < 2; i++)
            {
                if (direction.x == 1)
                {
                    positionRay.x = GetComponent<Engine>().Position.x + (size.x * 0.5f);

                }
                else
                {
                    positionRay.x = GetComponent<Engine>().Position.x - (size.x * 0.5f);
                }
                positionRay.y = GetComponent<Engine>().Position.y + (0.70f * size.y * i);
                hit = Physics2D.Raycast(positionRay, new Vector2(direction.x, 0), 1.0f);
                if (hit.collider != null)
                {
                    onHitX = true;
                    float dist = hit.distance;
                    if (direction.x == 1 && GetComponent<Engine>().MaxPositionX > (GetComponent<Engine>().Position.x + dist))
                    {
                        GetComponent<Engine>().MaxPositionX = GetComponent<Engine>().Position.x + dist;
                    }
                    else if (direction.x != 1 && GetComponent<Engine>().MinPositionX < (GetComponent<Engine>().Position.x - dist))
                    {
                        GetComponent<Engine>().MinPositionX = GetComponent<Engine>().Position.x - dist;
                    }
                }
                else if (onHitX == false)
                {
                    onHitX = false;
                    GetComponent<Engine>().MinPositionX = -40;
                    GetComponent<Engine>().MaxPositionX = 40;
                }
                //ray = new Ray2D(positionRay, new Vector2(direction.x, 0));
                Debug.DrawRay(positionRay, new Vector2(direction.x, 0), Color.green);

            }
        }
        if (direction.y != 0)
        {
            for (float i = -1; i < 2; i++)
            {
                if (direction.y == 1)
                {
                    positionRay.y = GetComponent<Engine>().Position.y + (size.y * 0.5f);

                }
                else
                {
                    positionRay.y = GetComponent<Engine>().Position.y - (size.y * 0.5f);

                }
                positionRay.x = GetComponent<Engine>().Position.x + (0.70f * size.y * i);
                hit = Physics2D.Raycast(positionRay, new Vector2(0, direction.y), 1.0f);
                if (hit.collider != null)
                {
                    onHitY = true;
                    Debug.Log(onHitY);
                    float dist = hit.distance;
                    if (direction.y == 1)
                    {
                        GetComponent<Engine>().MaxPositionY = GetComponent<Engine>().Position.y + dist;
                    }
                    else
                    {
                        GetComponent<Engine>().MinPositionY = GetComponent<Engine>().Position.y - dist;
                    }
                    //Debug.Log(dist);
                }
                else if (onHitY == false)
                {
                    onHitY = false;
                    GetComponent<Engine>().MaxPositionY = 20;
                    GetComponent<Engine>().MinPositionY = -20;
                }
                //ray = new Ray2D(positionRay, new Vector2(0, direction.y));
                Debug.DrawRay(positionRay, new Vector2(0, direction.y), Color.green);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRaycast();
        onHitX = false;
        onHitY = false;
    }
}
