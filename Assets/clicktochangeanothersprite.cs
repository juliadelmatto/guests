﻿using UnityEngine;

public class clicktochangeanothersprite : MonoBehaviour
{
    public bool click = false;
    public bool hover = true;
    private bool hovering = false;
    public GameObject objecttochange;
    public Sprite firstsprite;
    public Sprite secondsprite;
    public GameObject lightsky;
    public GameObject words;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hovering);

        if (hover)
        {

            if (hovering == true)
            {
                Debug.Log("WHY");
                objecttochange.GetComponent<SpriteRenderer>().sprite = secondsprite;
                lightsky.SetActive(true);
                words.SetActive(true);
            }
            if (hovering == false)
            {
                lightsky.SetActive(false);
                words.SetActive(false);
                objecttochange.GetComponent<SpriteRenderer>().sprite = firstsprite;

            }
        }
    }

    void OnMouseDown()
    {
        //if (click)
        //{
        //    if (objecttochange.GetComponent<SpriteRenderer>().sprite == firstsprite)
        //    {
        //        objecttochange.GetComponent<SpriteRenderer>().sprite = secondsprite;
        //    }
        //    else if (objecttochange.GetComponent<SpriteRenderer>().sprite == secondsprite)
        //    {
        //        objecttochange.GetComponent<SpriteRenderer>().sprite = firstsprite;
        //    }

        //}
    }

    void OnMouseOver()
    {
        hovering = true;

    }
    void OnMouseExit()
    {
        hovering = false;
    }

}
