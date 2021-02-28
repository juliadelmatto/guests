using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roo1 : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public Sprite dooropensprite;

    public TextMesh one;
    public TextMesh onetothree;
    public TextMesh threetoone;

    //public Text firstline;
    //public Text saysto3;
    //count of things to say
    public int count = 0;
    private bool touching;
    private string[] words = { "Hey there. Are you looking for the door?" };
    //, "","Can't you find your way out?", "There are exits everywhere" };

    public bool roo1isbusy = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //one.text = words[count];
        //Debug.Log(count);

        //firstline.transform.position =
            //new Vector2(this.transform.position.x,this.transform.position.y);
            //new Vector2(3f,3f);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "roo2") && roo1isbusy==false)

        {
            //Debug.Log("ONEANDTHREE");
            roo1isbusy = true;
            // Debug.Log("colliding");
            one.text = "The doors are over there. My underground friend has the key";
           one.gameObject.SetActive(true);


            //show doors
            door1.gameObject.SetActive(true);
            door2.gameObject.SetActive(true);
        }

        if ((collision.gameObject.name == "roo3")&& roo1isbusy==false)
            
        {

            roo1isbusy = true;
            Debug.Log("ONEANDTHREE");
            threetoone.text = "a little cold";
            onetothree.gameObject.SetActive(true);
            threetoone.gameObject.SetActive(true);
            
        }

        if (collision.gameObject.name == "pengu")

        {

            
            one.text = "thanks!";
            one.gameObject.SetActive(true);

            //Sprite door1 = Resources.Load("opendoor", typeof(Sprite)) as Sprite;
            door1.GetComponent<SpriteRenderer>().sprite = dooropensprite;

        }



    }

   
    void OnTriggerExit2D(Collider2D collision)
    {
        //when he is not touching roo2
        if (collision.gameObject.name == "roo2")
        {
           roo1isbusy = false;
            //set text equal to false
            one.gameObject.SetActive(false);
            //array count goes up
            //count += 1;

            //if (count > 1)
            //{
            //    gameObject.door1.SetActive(true);
            //    gameObject.door2.SetActive(true);
            //}
            one.text = "My friend underground might know where the key is.";
        }

        if (collision.gameObject.name == "roo3")
        {
            roo1isbusy = false;
            //set text equal to false
            threetoone.text = "";
            onetothree.gameObject.SetActive(false);
            threetoone.gameObject.SetActive(false);
            //array count goes up

        }

        if (collision.gameObject.name == "pengu")

        {


            one.text = "";
            one.gameObject.SetActive(false);


        }




    }


}
