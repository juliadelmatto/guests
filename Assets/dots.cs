using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dots : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1.5f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //goin left
        if ((Input.GetKey(KeyCode.A)))
        {

            // transform.position = new Vector2(2f,0f);
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else if ((Input.GetKey(KeyCode.D)))
        {
            // transform.position = new Vector2(2f,0f);
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }



        //goin down
        if ((Input.GetKey(KeyCode.S)))
        {
            // transform.position = new Vector2(2f,0f);
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        else if ((Input.GetKey(KeyCode.W) ))
        {
            // transform.position = new Vector2(2f,0f);
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
        }


    }
}
