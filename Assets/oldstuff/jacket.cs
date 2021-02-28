using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jacket : MonoBehaviour
{
    private Vector3 offset;
    public Transform pengu2;
    public Transform pengu;
    private bool abletomove = true;

    void OnMouseDown()
    {
        if (abletomove == true)
        {
            offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }
    }

    void OnMouseDrag()
    {
        if (abletomove == true)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetJacketasChild()
    {
        transform.SetParent(pengu2);
    }
    public void putjacketonpengu()
    {
        transform.SetParent(pengu);
    }

    public void abandonchild()
    {
        transform.parent = null;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "pengu2"))
        {
            //butterflythreewords.text = "butterflytres";
            //butterflythreewords.gameObject.SetActive(true);
            abletomove = false;
            //Debug.Log("ya");
            //transform.SetParent(pengu2);
        }
    }
}
