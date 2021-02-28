using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windows : MonoBehaviour
{
    private bool cangoin = false;

    private bool closed = false;
    private bool open = true;

    public Sprite closedwindow;
    public Sprite openwindow;
    public Sprite night;
    public Sprite day;
    public Sprite lightning;
    public Sprite normalcloud;
    public GameObject cloud;

    public GameObject blue;
    // Start is called before the first frame update
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
            // transform.position = new Vector2(2f,0f);
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        else if ((Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow))))
        {
            // transform.position = new Vector2(2f,0f);
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
        }
    }

    private void OnMouseDown()
    {
        if (closed==true)
        {
            //Debug.Log("AAAA");
            GetComponent<SpriteRenderer>().sprite = openwindow;
            blue.GetComponent<SpriteRenderer>().sprite = day;
            cloud.GetComponent<SpriteRenderer>().sprite = normalcloud;

            closed = false;
           
        }

        else if (closed == false)
        {
            //Debug.Log("asdf");
            GetComponent<SpriteRenderer>().sprite = closedwindow;
            blue.GetComponent<SpriteRenderer>().sprite = night;
            cloud.GetComponent<SpriteRenderer>().sprite = lightning;
            closed = true;
        }
    }


}
