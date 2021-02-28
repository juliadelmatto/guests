using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class doors3 : MonoBehaviour
{
   //public string scenename;
    //public string newscenename;
    public int doornumber = 1;

    public Sprite basicopen;
    public Sprite birdguyopen;
    public Sprite pinkgirlopen;
    public Sprite beachopen;
    public Sprite closedsprite;


    public AudioClip door;
    AudioSource audioSource;

    //private bool newdooropen = false;

    private bool open = false;
    public float speed;
    private bool readytogoin = false;

    public sequence s;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        


        readytogoin = false;
        s = GameObject.Find("SequenceManager").GetComponent<sequence>();
        speed = 1.4f;
       // Debug.Log(newdooropen);
    }

    // Update is called once per frame
    void Update()
    {
        //audioSource.PlayOneShot(door, 0.7F);

        //goin left
        if ((Input.GetKeyDown(KeyCode.A)))
        {

            // transform.position = new Vector2(2f,0f);
            GetComponent<Rigidbody2D>().velocity += new Vector2(speed, 0f);
        }

        //goin right
        if ((Input.GetKeyDown(KeyCode.D)))
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



        if (open == false)
        {

            GetComponent<SpriteRenderer>().sprite = closedsprite;
        }
        else if (open == true)
        {
            if (s.basicroom == false)
            {
                GetComponent<SpriteRenderer>().sprite = basicopen;
            }
            else if(doornumber == 1)
            {

                {
                    GetComponent<SpriteRenderer>().sprite = birdguyopen;

                }
            }
            else if (doornumber == 2)
            {

                {
                    GetComponent<SpriteRenderer>().sprite = beachopen;

                }
            }
            else if (doornumber == 3)
            {

                {
                    GetComponent<SpriteRenderer>().sprite = pinkgirlopen;

                }
            }
        }


        if (open)
        {
            print("open");
        }
        else
        {
            print("closed");
        }
        


    }

    private void OnMouseDown()
    {
        if (readytogoin == true)
        {
            if (s.basicroom == false)
            { 
                SceneManager.LoadScene("basicroom");
             }
            else
            {
                if (doornumber == 1)
                {
                    s.charactersvisited += 1;
                    SceneManager.LoadScene("house");
                }
                if (doornumber == 2)
                {
                    s.charactersvisited += 1;
                    SceneManager.LoadScene("beach");
                }
                if (doornumber == 3)
                {
                    s.charactersvisited += 1;
                    SceneManager.LoadScene("pinkgirl");
                }
            }
            //load the scene
        }
        else
        {
            audioSource.PlayOneShot(door, 0.5F);
            //play sound
            //print("open");
            
            open = true;
            readytogoin = true;
        }
        
        //if (s.basicroom == false)
        //{
        //    if (readytogoin == true)
        //    {
        //        SceneManager.LoadScene("basicroom");

        //    }

        //    if (open == false)
        //    {
        //        open = true;
        //        readytogoin = true;
        //    }

        //}

        //if (s.basicroom == true)
        //{
        //    if (readytogoin == true)
        //    {
        //        SceneManager.LoadScene("house");

        //    }

        //    if (open == false)
        //    {
        //        open = true;
        //        readytogoin = true;
        //    }

        //}

    }
   
}
