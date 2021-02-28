using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{
    //public GameObject door;
    public string scenename;
    public string newscenename;
    public Sprite opensprite;
    public Sprite closedsprite;
    public Sprite spacesprite;

    //public GameObject pillar1;
    //public GameObject pillar2;
    //public GameObject pillar3;

    private bool touchedpillar = false;
    private bool newdooropen = false;

    private bool open = false;
    public float speed;
    private bool readytogoin = false;


    // Start is called before the first frame update
    void Start()
    {
        
        speed = 1.4f;
        Debug.Log(newdooropen);
    }

    // Update is called once per frame
    void Update()
    {
        //goin left
        if ((Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.LeftArrow))))
        {

            // transform.position = new Vector2(2f,0f);
            GetComponent<Rigidbody2D>().velocity += new Vector2(speed, 0f);
        }

        //goin right
        if ((Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.RightArrow))))
        {
            // transform.position = new Vector2(2f,0f);
            GetComponent<Rigidbody2D>().velocity += new Vector2(-speed, 0f);
        }

        if (Input.anyKey == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }



        if (transform.position.x > 14)
        {
            transform.position = new Vector2(-14.22f, -0.14f);
        }

        if (transform.position.x < -15)
        {
            transform.position = new Vector2(13f, -0.14f);
        }

        if (touchedpillar == false)
        {
            //sprite stuff
            if (open == false)
            {
                // door.gameObject.SetActive(true);
                //open = true;
                GetComponent<SpriteRenderer>().sprite = closedsprite;
            }
            else if (open == true)
            {
                //closed sprite
                //door.gameObject.SetActive(false);
                //open = false;
                GetComponent<SpriteRenderer>().sprite = opensprite;

            }
        }


    }

    private void OnMouseDown()
    {
        //if(newdooropen == true)
        //{
        //    SceneManager.LoadScene(newscenename);
        //}
        if (readytogoin == true)
        {
            if (newdooropen == true)
            {
                SceneManager.LoadScene(newscenename);
            }
            else
            {
                SceneManager.LoadScene(scenename);
            }
            
        }
        if (open == false)
        {
            open = true;
            readytogoin = true;
        }
        //if(open== true)


    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "pillar")
        {
            
            if (open == true)
            {
                touchedpillar = true;
                //Debug.Log("sdf");

                //WHY ISNT THIS WORKING????
                GetComponent<SpriteRenderer>().sprite = spacesprite;
                newdooropen = true;
                //SpriteRenderer s = GetComponent<SpriteRenderer>();
                //if (s == null)
                //{
                //    Debug.Log("s is null");
                //}
                //else
                //{
                //    Debug.Log("its fine");
                //}

            }
        }
        
    }
    //private void OnMouseExit()
    //{

    //        open = false;



    //}
}

