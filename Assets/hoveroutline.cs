using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoveroutline : MonoBehaviour
{
    public GameObject outline;
    public Sprite normalsprite;
    public Sprite headopen;
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
        Debug.Log("hover");
        //outline.gameObject.SetActive(true);

        this.GetComponent<SpriteRenderer>().sprite = headopen;
    }

    private void OnMouseExit()
    {
        //outline.gameObject.SetActive(false);
        this.GetComponent<SpriteRenderer>().sprite = normalsprite;
    }

   

}
