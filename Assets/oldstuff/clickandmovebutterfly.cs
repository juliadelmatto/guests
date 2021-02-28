using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickandmovebutterfly : MonoBehaviour
{
    private Vector3 offset;
    private bool abletomove = true;
    public Transform pengu;

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
        if ((collision.gameObject.name == "pengu"))
        {
            //butterflythreewords.text = "butterflytres";
            //butterflythreewords.gameObject.SetActive(true);
            abletomove = false;
            //Debug.Log("ya");
            transform.SetParent(pengu);
        }
    }


}
