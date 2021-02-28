using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayedappear : MonoBehaviour
{

    public GameObject objecttoappear;
    private int length =100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(length);
        length--;
        if (length < 0)
        {
            objecttoappear.SetActive(true);
        }

    }
}
