using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downhole : MonoBehaviour
{
    public Camera cam;
    public GameObject arrow;
    public Vector2 destination;
    public float speedoftransition;

    public bool cameramovebool=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cameramovebool == true)
        {
            lerpCamera(destination);
        }
    }

    private void OnMouseOver()
    {
        arrow.gameObject.SetActive(true);
//        Debug.Log("touching");
    }

    private void OnMouseExit()
    {
        arrow.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        
        cameramovebool = true;
    }

    public void lerpCamera (Vector2 dest)
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position,
            new Vector3(dest.x,dest.y,-10),
            speedoftransition);

        if (Vector2.Distance(Camera.main.transform.position,dest)<0.05) {

            Camera.main.transform.position = new Vector3(dest.x, dest.y, -10);
            cameramovebool = false;
        }
    }

}
