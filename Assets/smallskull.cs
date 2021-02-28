using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallskull : MonoBehaviour
{
    public GameObject grave4;
    public Sprite filled4;
    public GameObject grave5;
    public Sprite filled5;
    public GameObject grave6;
    public Sprite filled6;

    public GameObject underground;

    private bool colwithgrave4 = false;
    private bool colwithgrave5 = false;
    private bool colwithgrave6 = false;

    private bool f1 = false;
    private bool f2 = false;
    private bool f3 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (colwithgrave4)
        {
            grave4.GetComponent<SpriteRenderer>().sprite = filled4;
            f1 = true;
        }
        if (colwithgrave5)
        {
            grave5.GetComponent<SpriteRenderer>().sprite = filled5;
            f2 = true;
        }
        if (colwithgrave6)
        {
            grave6.GetComponent<SpriteRenderer>().sprite = filled6;
            f3 = true;
        }

        if (f1 && f2 && f3)
        {
            underground.gameObject.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "grave4")
        {


            colwithgrave4 = true;
        }
        if (collision.gameObject.name == "grave5")
        {


            colwithgrave5 = true;
        }
        if (collision.gameObject.name == "grave6")
        {


            colwithgrave6 = true;
        }
    }
}
