using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hovertext : MonoBehaviour
{

    public GameObject popup;
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
        popup.gameObject.SetActive(true);
        Debug.Log("sdf");
    }

    private void OnMouseExit()
    {
        popup.gameObject.SetActive(false);
    }
}
