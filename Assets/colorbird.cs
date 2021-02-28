using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorbird : MonoBehaviour
{

    public bool yellow = false;
    public bool green = false;
    public bool blue = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (blue)
        {
            this.GetComponent<Animator>().SetBool("blue", true);
            this.GetComponent<Animator>().SetBool("green", false);
            this.GetComponent<Animator>().SetBool("yellow", false);
        }
        else if (green)
        {
            this.GetComponent<Animator>().SetBool("green", true);
            this.GetComponent<Animator>().SetBool("blue", false);
            this.GetComponent<Animator>().SetBool("yellow", false);
        }
        else if (yellow)
        {
            this.GetComponent<Animator>().SetBool("yellow", true);
            this.GetComponent<Animator>().SetBool("green", false);
            this.GetComponent<Animator>().SetBool("blue", false);
        }
    }
}
