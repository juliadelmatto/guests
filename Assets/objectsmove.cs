using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsmove : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb;
    public bool keystomove = true;
    public bool mousetomove = false;
    public bool onlyupanddown = false;
    public bool stick=false;
    // Start is called before the first frame update
    void Start()
    {
        //speed = 3f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stick == false)
        {
            if (keystomove)
            {
                if (!onlyupanddown)
                {
                    //goin left
                    if ((Input.GetKey(KeyCode.A)))
                    {

                        // transform.position = new Vector2(2f,0f);
                        rb.velocity = new Vector2(speed, rb.velocity.y);
                    }
                    //goin right
                    else if ((Input.GetKey(KeyCode.D)))
                    {
                        // transform.position = new Vector2(2f,0f);
                        rb.velocity = new Vector2(-speed, rb.velocity.y);
                    }
                    else
                    {
                        rb.velocity = new Vector2(0f, rb.velocity.y);
                    }
                }


                //goin down
                if ((Input.GetKey(KeyCode.S)))
                {
                    // transform.position = new Vector2(2f,0f);
                    rb.velocity = new Vector2(rb.velocity.x, speed);
                }
                else if ((Input.GetKey(KeyCode.W)))
                {
                    // transform.position = new Vector2(2f,0f);
                    rb.velocity = new Vector2(rb.velocity.x, -speed);
                }
                else
                {
                    rb.velocity = new Vector2(rb.velocity.x, 0f);

                }
            }
            //end of keys to move
            // Debug.Log(Input.mousePosition.x + ", " + Input.mousePosition.y);
        }
    }

}
