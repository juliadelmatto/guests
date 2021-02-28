using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childrencount : MonoBehaviour
{
    public bool gotenoughkids = false;
    public int howmanykids = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hierarchyCount > howmanykids)
        {

            gotenoughkids = true;
        }
    }
}
