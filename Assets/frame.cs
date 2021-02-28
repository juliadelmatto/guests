using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frame : MonoBehaviour
{
    private bool closed = false;
    public Sprite openwindow;
    public Sprite closedwindow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (closed == true)
        {
            //Debug.Log("AAAA");
            GetComponent<SpriteRenderer>().sprite = openwindow;
            

            closed = false;

        }

        else if (closed == false)
        {
            //Debug.Log("asdf");
            GetComponent<SpriteRenderer>().sprite = closedwindow;
            
            closed = true;
        }
    }



}
