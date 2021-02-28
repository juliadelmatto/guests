using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousehover : MonoBehaviour
{
    public Sprite thissprite;
    public Sprite hoversprite;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().sprite = hoversprite;
    }


    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = thissprite;
    }
}
