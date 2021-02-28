using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangle : MonoBehaviour
{
    public GameObject grave1obj;
    public Sprite grave1;
    public Sprite grave1collided;

    public GameObject grave2obj;
    public Sprite grave2;
    public Sprite grave2collided;

    public GameObject grave3obj;
    public Sprite grave3;
    public Sprite grave3collided;

    private bool colwithgrave=false;
    private bool colwithskull = false;
    private bool one = false;
    private bool two = false;
    private bool three = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(colwithgrave && colwithskull)
        {
            if (one){
                grave1obj.GetComponent<SpriteRenderer>().sprite = grave1collided;
            }
            if (two)
            {
                grave2obj.GetComponent<SpriteRenderer>().sprite = grave2collided;
            }
            if (three)
            {
                grave3obj.GetComponent<SpriteRenderer>().sprite = grave3collided;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "grave1") {

            //touchingmouth = true;
            //collision.gameObject.GetComponent<mouth>().portalmouth = true;
            // print("grave");
            one = true;
            colwithgrave = true;
        }
        if (collision.gameObject.name == "grave2")
        {

            //touchingmouth = true;
            //collision.gameObject.GetComponent<mouth>().portalmouth = true;
            // print("grave");
            two = true;
            colwithgrave = true;
        }
        if (collision.gameObject.name == "grave3")
        {

            //touchingmouth = true;
            //collision.gameObject.GetComponent<mouth>().portalmouth = true;
            // print("grave");
            three = true;
            colwithgrave = true;
        }

        if (collision.gameObject.name == "skull")
        {

            //touchingmouth = true;
            //collision.gameObject.GetComponent<mouth>().portalmouth = true;
            colwithskull = true;
           // print("skull");
        }

        

    }

    



    }



