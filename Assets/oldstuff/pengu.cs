using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pengu : MonoBehaviour
{
   
    public TextMesh penguwords;
    public TextMesh coldtext;
    public TextMesh jumpinstructions;

    private int delay = 0;
    private bool startdelay = false;
    // Start is called before the first frame update
    public bool gotjacket = false;
    private bool canjump = false;

    private int threshold = -9;
    private bool firstwords = true;

    private Rigidbody2D _rigidBody2D;
    float starty;


    void Start()
    {
        starty = transform.position.y;
    }
    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //delay speaking to pengu2
        if (startdelay == true)
        {
            delay += 1;
            //Debug.Log(delay);

            if (delay > 40)
            {
                penguwords.gameObject.SetActive(true);
            }

            
        }

        if (gotjacket)
        {
            
            threshold = 4;
        }
        if (canjump)
        {
            jumpinstructions.gameObject.SetActive(true);
        }

        if (transform.position.y < starty)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            transform.position = new Vector2(transform.position.x, starty);
        }

       //can only jump if below threshold
        if (transform.position.y < threshold)
        {
            if (Input.GetKeyDown(KeyCode.Space) && (canjump == true))
             {
                Debug.Log(transform.position.y);
            
                GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 4f);
            }


            //he says its too cold
            if ((transform.position.y > -10) && (gotjacket==false))
            {
                coldtext.gameObject.SetActive(true);
            }

            if ((transform.position.y < -12) && (gotjacket == false))
            {
                coldtext.gameObject.SetActive(false);
            }





        }





    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "pengu2"))
        {
            
                startdelay = true;
            if(!gotjacket)
            {
                penguwords.text = "I would bring it up but its so cold up there, could you get my jacket?";
                
            }
            else
            {
                penguwords.text = "Thanks!";
            }
        }

        if ((collision.gameObject.name == "roo1"))
        {
            
            penguwords.text = "Heres the key!";
            penguwords.gameObject.SetActive(true);
            //set door to open

        }

        if ((collision.gameObject.name == "roo2"))
        {

            penguwords.text = "Ummm no!";
            penguwords.gameObject.SetActive(true);
            //set door to open

        }

        if ((collision.gameObject.name == "two"))
        {
            canjump = true;

        }

        if ((collision.gameObject.name == "hesgoinup"))
        {
            GameObject.Find("hesgoinup").GetComponent<downhole>().cameramovebool = true;

        }

        //if collides with second box then the ground is reset
        if ((collision.gameObject.name == "newground"))
        {
            starty = -3;

        }

        if ((collision.gameObject.name == "one"))
        {
            penguwords.text = "get away from me";
            penguwords.gameObject.SetActive(true);

        }
        if ((collision.gameObject.name == "three"))
        {
            penguwords.text = "you are annoying me";
            penguwords.gameObject.SetActive(true);

        }

        if ((collision.gameObject.name == "stop"))
        {
            penguwords.text = "get away from me";
            penguwords.gameObject.SetActive(true);

        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "pengu2"))
        { 
            penguwords.gameObject.SetActive(false);
            penguwords.text = "";
            firstwords = false;

        }

        if ((collision.gameObject.name == "roo1"))
        {
            penguwords.gameObject.SetActive(false);
            penguwords.text = "";

        }

        if ((collision.gameObject.name == "one"))
        {
            penguwords.gameObject.SetActive(false);
            penguwords.text = "";

        }
        if ((collision.gameObject.name == "two"))
        {
            penguwords.gameObject.SetActive(false);
            penguwords.text = "";

        }
        if ((collision.gameObject.name == "three"))
        {
            penguwords.gameObject.SetActive(false);
            penguwords.text = "";

        }

        if ((collision.gameObject.name == "roo2"))
        {

            penguwords.text = "";
            penguwords.gameObject.SetActive(false);
            //set door to open

        }
    }

    
}
