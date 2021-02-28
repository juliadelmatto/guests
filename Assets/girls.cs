using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girls : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3f;
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



        
       

    }
    //void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.gameObject.name == "girl")
    //    {

    //        touchingmouth = true;
    //        collision.gameObject.GetComponent<mouth>().portalmouth = true;
    //    }

    //}
}
