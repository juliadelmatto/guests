using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2 : MonoBehaviour
{
    public sequence s;

    private string basicroom;
    private string beach;
    private string house;
    private string pinkgirl;
    private string blankroom;

    private bool open = false;

    private bool readytogoin = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (open == false)
        //{
        //    // door.gameObject.SetActive(true);
        //    //open = true;
        //    GetComponent<SpriteRenderer>().sprite = closedsprite
        //}
        //else if (open == true)
        //{
        //    //closed sprite
        //    //door.gameObject.SetActive(false);
        //    //open = false;
        //    GetComponent<SpriteRenderer>().sprite = opensprite;

        //}

       
    }

    private void OnMouseDown()
    {
      
        //if (readytogoin == true)
        //{
        //    if (newdooropen == true)
        //    {
        //        SceneManager.LoadScene(newscenename);
        //    }
        //    else
        //    {
        //        SceneManager.LoadScene(scenename);
        //    }

        //}




        if (open == false)
        {
            open = true;
            readytogoin = true;
        }
        //if(open== true)


    }
}
