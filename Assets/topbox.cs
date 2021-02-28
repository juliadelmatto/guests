using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topbox : MonoBehaviour
{
    public Transform backing;
    public string nameofcollidingobject;

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
        
            if (collision.gameObject.name == nameofcollidingobject)
            {
                Debug.Log("collisiom");
                transform.SetParent(backing);
                this.transform.GetComponent<looping>().abletoloop = false;
        }
        
            
    }
}
