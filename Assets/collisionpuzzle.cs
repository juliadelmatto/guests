﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionpuzzle : MonoBehaviour
{
    public GameObject portal;
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
        if (collision.gameObject.name == "portal")
        {

            //touchingmouth = true;
            //collision.gameObject.GetComponent<mouth>().portalmouth = true;
            Debug.Log("hitportal");
            portal.SetActive(true);

            //canmove = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        portal.SetActive(false);
    }
}
