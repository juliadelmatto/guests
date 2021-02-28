using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    private bool flying = true;
    private bool upanddown = false;
    public Sprite sitting;
    public float speed;
    Rigidbody2D rb;
    public Transform circle;
    // Start is called before the first frame update

    public GameObject red1;
    public GameObject red2;
    public GameObject red3;
    public GameObject red4;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flying) {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            if (upanddown)
            {
                if ((Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow))))
                {
                    // transform.position = new Vector2(2f,0f);
                    rb.velocity = new Vector2(rb.velocity.x, 4);
                }
                else if ((Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow))))
                {
                    // transform.position = new Vector2(2f,0f);
                    rb.velocity = new Vector2(rb.velocity.x, -4);
                }
                else
                {
                    rb.velocity = new Vector2(rb.velocity.x, 0f);

                }
            }
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "circle")
        {
            Debug.Log("collision");
            // this.Renderer.sortingOrder = 1;
            // transform.SetParent(circle);
            // this.transform.GetComponent<looping>().abletoloop = false;
            upanddown = true;
        }
        if (collision.gameObject.name == "branch")
        {
            flying = false;
            upanddown = false;
            rb.velocity = new Vector2(0f, 0f);
            this.GetComponent<Animator>().SetBool("sit", true);
            //GetComponent<SpriteRenderer>().sprite = sitting;
            red1.SetActive(true);
            red2.SetActive(true);
            red3.SetActive(true);
            red4.SetActive(true);
        }


    }

    void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.name == "circle")
        {
            upanddown = false;
            //Debug.Log("exi");

        }


    }
}
