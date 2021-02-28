using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squaremove : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    private bool canmove=true;
    public GameObject bar;
    // Start is called before the first frame update
    void Start()
    {
        //speed = 3f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //goin left
        if ((Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow))))
        {

            // transform.position = new Vector2(2f,0f);
            
                rb.velocity = new Vector2(speed, rb.velocity.y);
            
           
        }
        else if ((Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow))))
        {
            // transform.position = new Vector2(2f,0f);
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }



        //goin down
        if ((Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow))))
        {
            //if (canmove)
            //{
                // transform.position = new Vector2(2f,0f);
                rb.velocity = new Vector2(rb.velocity.x, speed);
            //}
        }
        //goin up
        else if ((Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow))))
        {
            // transform.position = new Vector2(2f,0f);
            rb.velocity = new Vector2(rb.velocity.x, -speed);
            if (canmove)
            {
               // rb.velocity = new Vector2(rb.velocity.x, -speed);
            }
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
        }
        
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x,bar.transform.position.x-6f,bar.transform.position.x+6f),
            Mathf.Clamp(transform.position.y, bar.transform.position.y - 2f, bar.transform.position.y + 2f),
            - 57.49963f);

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wall")
        {

            //touchingmouth = true;
            //collision.gameObject.GetComponent<mouth>().portalmouth = true;
             Debug.Log("hitwall");


            canmove = false;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wall")
        {

            //touchingmouth = true;
            //collision.gameObject.GetComponent<mouth>().portalmouth = true;
            Debug.Log("hitwall");


            canmove = true;
        }
    }


}
