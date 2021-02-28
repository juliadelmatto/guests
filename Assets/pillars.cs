using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillars : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2.3f;
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
        if ((Input.GetKeyDown(KeyCode.D)|| (Input.GetKeyDown(KeyCode.RightArrow))))
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
            transform.position = new Vector2(-14.22f,0f);
        }

        if (transform.position.x < -15)
        {
            transform.position = new Vector2(13f, 0f);
        }
    }
}
