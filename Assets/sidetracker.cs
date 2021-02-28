using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidetracker : MonoBehaviour
{

    private int stopup = 10;
    private int stopdown = 10;
    private int stopright;
    public int stopleft;

    private int uptrack = 0;
    private int sidetrack = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (((Input.GetKey(KeyCode.W))))
        {
            stopup++;
        }
        else if ((Input.GetKey(KeyCode.S))){
            stopup--;
        }
        else if ((Input.GetKey(KeyCode.D))){
            sidetrack++;
        }
        else if ((Input.GetKey(KeyCode.A)))
        {
            sidetrack--;
        }


    }
}
