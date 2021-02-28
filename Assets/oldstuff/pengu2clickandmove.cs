using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pengu2clickandmove : MonoBehaviour
{

    private Vector3 offset;
    private bool inhouse=false;
    private bool isunderground = true;
    bool clicking = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 12f)
        {
           // isunderground = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            clicking = false;
        }
        if (clicking)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
        
    }

   

    void OnMouseDown()
    {
        clicking = true;
        offset = gameObject.transform.position -
        Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    }

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "house"))

        {
            //penguwords.text = "I overheard the kangaroos up there saying they need your key";
            //penguwords.gameObject.SetActive(true);
            //Debug.Log("move peng");
            clicking = false;
            transform.position = new Vector3(15.09f, -10.78f, 0f);
        }

        if ((collision.gameObject.name == "door"))

        {
            //penguwords.text = "I overheard the kangaroos up there saying they need your key";
            //penguwords.gameObject.SetActive(true);
            //Debug.Log("move peng");
            clicking = false;
            transform.position = new Vector3(0f, -13.16f, 0f);
        }
    }

    
}
