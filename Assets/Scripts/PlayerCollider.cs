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
        direction = GetComponent<InputController>().Axis;
        if (direction.x != 0)
        {
            /**
            if (direction.x == 1)
            {
                positionRay.x = GetComponent<Engine>().Position.x + size.x;

            }
            else
            {
                positionRay.x = GetComponent<Engine>().Position.x - size.x;
            }**/
            for (float i = -1; i < 2; i++)
            {
                if (direction.x == 1)
                {
                    positionRay.x = GetComponent<Engine>().Position.x + size.x/2;

                }
                else
                {
                    positionRay.x = GetComponent<Engine>().Position.x - size.x/2;
                }
                positionRay.y = GetComponent<Engine>().Position.y + ((95/100)*size.y * i);
                hit = Physics2D.Raycast(positionRay, new Vector2(direction.x, 0), 2.0f);
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
                Debug.DrawRay(positionRay, new Vector2(direction.x * 2, 0), Color.green);

            }
        }
        if (direction.y != 0)
        {
            for (float i = -1; i < 2; i++)
            {
                if (direction.y == 1)
                {
                    positionRay.y = GetComponent<Engine>().Position.y + size.y/2;

                }
                else
                {
                    positionRay.y = GetComponent<Engine>().Position.y - size.y/2;

                }
                positionRay.x = GetComponent<Engine>().Position.x + ((95 / 100) * size.y * i);
                hit = Physics2D.Raycast(positionRay, new Vector2(0, direction.y), 2.0f);
                if (hit.collider != null)
                {
                    onHitY = true;
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
                Debug.DrawRay(positionRay, new Vector2(0, direction.y * 2), Color.green);
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
