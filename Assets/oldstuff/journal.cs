using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class journal : MonoBehaviour
{

    public GameObject openjournal;
    private bool open = false;
    public Sprite opensprite;
    public Sprite closedsprite;

    public static journal instance;


    //prevent from duplicating
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //follow main camera
        transform.position = new Vector3(
            Camera.main.transform.position.x-7.433f,
           Camera.main.transform.position.y+3f,
            -2f);
    }

    void OnMouseDown()
    {
        //open journal
        Debug.Log("journal");
        
        if (open == false)
        {
            openjournal.gameObject.SetActive(true);
            open = true;
            GetComponent<SpriteRenderer>().sprite = opensprite;
        }
        else if (open == true)
        {
            //closed sprite
            openjournal.gameObject.SetActive(false);
            open = false;
            GetComponent<SpriteRenderer>().sprite = closedsprite;
        }
    }

   
}
