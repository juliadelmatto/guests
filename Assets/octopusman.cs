using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class octopusman : MonoBehaviour
{
    public TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        text.gameObject.SetActive(true);

    }
    private void OnMouseExit()
    {
        text.gameObject.SetActive(false);

    }
}
