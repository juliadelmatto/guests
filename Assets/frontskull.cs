using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontskull : MonoBehaviour
{
    public GameObject exitwords;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 4)
        {
            exitwords.gameObject.SetActive(true);
        }
            //Debug.Log(transform.childCount);
    }
}
