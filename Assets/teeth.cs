using UnityEngine;
using System.Collections;


public class teeth : MonoBehaviour
{

    private Vector3 offset;
 
    public bool rooted = false;

    public Transform skull;

    private void Update()
    {
        if (rooted)
        {
          transform.SetParent(skull);
        }
    }
    void OnMouseDown()
    {
        if (rooted == false)
        {
            offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }
    }

    void OnMouseDrag()
    {
        if (rooted == false)
        {


            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }

   



}