using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mouth : MonoBehaviour
{
    public Sprite openmouthsprite;
    public bool portalmouth = true;
    private bool youcangoin = false;

    // Start is called before the first frame update
    void Start()
    {
        portalmouth = false;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (portalmouth == true)
        {
            Debug.Log("portalmouth is true");
            GetComponent<SpriteRenderer>().sprite = openmouthsprite;
            youcangoin = true;
            
        }
    }

    private void OnMouseDown()
    {
        if (youcangoin)
        {
            SceneManager.LoadScene("stairs");
        }
    }
}
