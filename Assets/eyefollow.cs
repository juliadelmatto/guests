using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyefollow : MonoBehaviour
{
    public float factor = 0.25f;
    public float limit = 5f;

    private Vector3 center;

    //private Vector3 followPosition;
    void Start()
    {
        //Capture the starting position as a vector3
        center = transform.position;
    }


    void Update()
    {
        //Convert mouse pointer cords into a worldspace vector3
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0.0f;

        //Create a dir target based on mouse vector * factor
        Vector3 dir = pos * factor;

        //Clamp the dir target
        dir = Vector3.ClampMagnitude(dir, limit);

        //Update the pupil position
        transform.position = center + dir;

        //DELAYED
        //Convert mouse pointer cords into a worldspace vector3
        //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //pos.z = 0.0f;

        //followPosition = Vector3.Lerp(followPos, pos, Time.deltaTime * followFactor);

        ////Create a dir target based on mouse vector * factor
        //Vector3 dir = followPosition * factor;

        ////Clamp the dir target
        //dir = Vector3.ClampMagnitude(dir, limit);

        ////Update the pupil position
        //transform.position = center + dir;
    }
}
