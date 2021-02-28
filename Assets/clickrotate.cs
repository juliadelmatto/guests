using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickrotate : MonoBehaviour
{
    private bool rotate = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            transform.Rotate(Vector3.forward * (Time.deltaTime*30));
        }
    }

    private void OnMouseDown()
    {
        rotate = true;
        
    }
    private void OnMouseUp()
    {
        rotate = false;
    }
}
