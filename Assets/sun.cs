using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour
{
    public GameObject portal;
    public GameObject e1;
    public GameObject e2;
    public GameObject e3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //check that it happens on screen
        if ((transform.position.x > -12)&&(transform.position.x < 12))
        {
            if (collision.gameObject.name == "moon")
            {
                Debug.Log("sun");

                portal.gameObject.SetActive(true);
                e1.gameObject.SetActive(true);
                e2.gameObject.SetActive(true);
                e3.gameObject.SetActive(true);
            }
        }
    }
}
