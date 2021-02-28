using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roo2 : MonoBehaviour
{
    public TextMesh two;
    public TextMesh three;

    private int count =0;
    //public Text roo2line;
    // Start is called before the first frame update

    private bool roo2isbusy = false;

    void Start()
    {
        two.text = "Do you know where the door is?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "roo1")&& roo2isbusy==false)
        {

            roo2isbusy = true;
            //count += 1;

            two.gameObject.SetActive(true);

            two.gameObject.SetActive(true);

        }

        if ((collision.gameObject.name == "roo3") && roo2isbusy == false)
        {
            Debug.Log("thwo and three");
            roo2isbusy = true;
            two.text = "hello there";
            three.text = "just wanted to check the time, thanks!";
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(true);

        }

        if ((collision.gameObject.name == "pengu"))
        {

            two.text = "Hey aren't you still borrowing my book?";
            two.gameObject.SetActive(true);
            //set door to open

        }

    }


    void OnTriggerExit2D(Collider2D collision)
    {
        //when he is not touching roo2
        if (collision.gameObject.name == "roo1")
        {
            roo2isbusy = false;
            //set text equal to false
            two.gameObject.SetActive(false);
            //array count goes up
            two.text = "Its locked.";
        }

        if ((collision.gameObject.name == "roo3"))
        {
            roo2isbusy = false;
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            two.text = "";
            three.text = "";

        }

        if ((collision.gameObject.name == "pengu"))
        {

            two.text = "";
            two.gameObject.SetActive(false);
            //set door to open

        }


    }
}
