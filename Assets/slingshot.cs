using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slingshot : MonoBehaviour
{
    private bool touchingmouth = false;
    private bool go = false;
    private bool down = true;
    private bool up = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (go==true)
        {
            Slingshot();
        }

        if (touchingmouth)
        {
            gameObject.SetActive(false);
        }

       // Debug.Log(touchingmouth);
    }

    private void OnMouseDown()
    {

        go= true;
        

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("mouth") && up && go)
        {
            
            touchingmouth = true;
            collision.gameObject.GetComponent<mouth>().portalmouth = true;
        }

    }

    //void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.name == "mouth")
    //    {
    //        touchingmouth = false;

    //    }

    //}

    void Slingshot()
    {

        if (down == true)
        {
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            if (transform.localScale.x < 0)
            {
                down = false;
                up = true;
            }
        }
        if (up == true)
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            if(transform.localScale.x > 1.6)
            {
                up = false;
                down = true;
                go = false;
            }
                
        }
            
           
            //go = false;
        
        
    }
}
