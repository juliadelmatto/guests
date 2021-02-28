using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowlymove : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    float m_Speed;
    float r_Speed;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
        m_Speed = 0.05f;
        r_Speed = 0.2f;
    }

    void Update()
    {
        
            //Move the Rigidbody to the right constantly at speed you define (the red arrow axis in Scene view)
            m_Rigidbody.velocity = transform.right * m_Speed;
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * r_Speed, Space.World);
    }
}