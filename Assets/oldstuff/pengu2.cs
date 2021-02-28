using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pengu2 : MonoBehaviour
{
    public TextMesh penguwords;
    private bool gotjacket=false;

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
        if ((collision.gameObject.name == "pengu"))

        {
            if (gotjacket == false)
            {
                penguwords.text = "I overheard the kangaroos up there saying they need your key";
                penguwords.gameObject.SetActive(true);
            }
            else
            {
                penguwords.text = "now you won't be cold!";
                penguwords.gameObject.SetActive(true);

            }

            if(gotjacket == true)
            {
                //transfer the jacket!!!
                GameObject.Find("jacket").GetComponent<jacket>().abandonchild();
                GameObject.Find("jacket").GetComponent<jacket>().putjacketonpengu();
                GameObject.Find("pengu").GetComponent<pengu>().gotjacket=true;

                //GameObject.Find("pengu").GetComponent<penguwordsq>().text = "thanks!";

            }

        }

        if ((collision.gameObject.name == "house"))

        {
            //penguwords.text = "I overheard the kangaroos up there saying they need your key";
            //penguwords.gameObject.SetActive(true);
           // Debug.Log("move peng");
          // transform.position = new Vector3(13.09f, -10.78f, -10f);
        }


        if ((collision.gameObject.name == "jacket"))
        {
            //butterflythreewords.text = "butterflytres";
            //butterflythreewords.gameObject.SetActive(true);
            //abletomove = false;
            Debug.Log("ya");
            //transform.SetParent(pengu);
            GameObject.Find("jacket").GetComponent<jacket>().SetJacketasChild();
            gotjacket = true;
        }

        if ((collision.gameObject.name == "one"))
        {
            penguwords.text = "hi!";
            penguwords.gameObject.SetActive(true);
        }

        if ((collision.gameObject.name == "two"))
        {
            penguwords.text = "how are you?";
            penguwords.gameObject.SetActive(true);
        }

        if ((collision.gameObject.name == "three"))
        {
            penguwords.text = "hey!";
            penguwords.gameObject.SetActive(true);
        }

        if ((collision.gameObject.name == "four"))
        {
            penguwords.text = "hello!";
            penguwords.gameObject.SetActive(true);
        }

    }



    void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "pengu"))
        {
            penguwords.gameObject.SetActive(false);
            penguwords.text = "";
        }

        if ((collision.gameObject.name == "one")|| (collision.gameObject.name == "two") || (collision.gameObject.name == "three") || (collision.gameObject.name == "four"))
        {
            penguwords.gameObject.SetActive(false);
            penguwords.text = "";
        }
    }
}
