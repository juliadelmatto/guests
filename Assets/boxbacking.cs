using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxbacking : MonoBehaviour
{
    public Sprite openbox;
    public GameObject entryway;
    public int numberofchildren;
    public GameObject text;

    public GameObject blue;
    public GameObject purple;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.hierarchyCount > 4)&& (blue.transform.hierarchyCount > 3) && (purple.transform.hierarchyCount > 3))
        {
            
            GetComponent<SpriteRenderer>().sprite = openbox;
            entryway.SetActive(true);
            text.SetActive(true);
        }
        
    }
    //(blue.transform.GetComponent<childrencount>().gotenoughkids = true)
}
