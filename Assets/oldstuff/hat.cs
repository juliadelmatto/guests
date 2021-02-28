using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hat : MonoBehaviour
{
    private Vector3 offset;
    private bool abletomove = true;
    public Transform pengu2;

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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "pengu2"))
        {
            //butterflythreewords.text = "butterflytres";
            //butterflythreewords.gameObject.SetActive(true);
            
            //Debug.Log("ya");
            transform.SetParent(pengu2);
            abletomove = false;
        }
    }
}
