using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkforcharacters : MonoBehaviour
{
    public GameObject frame1;
    public Sprite pinkgirlframe;
    public GameObject frame2;
    public Sprite emogirlframe;
    public GameObject frame3;
    public Sprite birdframe;

    

    public static checkforcharacters instance;
    //public bool pinkgirl = true;
    //public bool emogirl = true;
    //public bool birdguy = true;

    //prevent from duplicating
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("BooleanManager").GetComponent<booleanmanager>().pinkgirl == true)
        {
            frame1.GetComponent<SpriteRenderer>().sprite = pinkgirlframe;
        }
        if (GameObject.Find("BooleanManager").GetComponent<booleanmanager>().emogirl == true)
        {
            frame2.GetComponent<SpriteRenderer>().sprite = emogirlframe;
        }
        if (GameObject.Find("BooleanManager").GetComponent<booleanmanager>().birdguy == true)
        {
            frame3.GetComponent<SpriteRenderer>().sprite = birdframe;
        }
    }
}
