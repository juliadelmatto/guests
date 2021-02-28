using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterflytwo : MonoBehaviour
{

    public TextMesh butterflytwowords;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "pengu2"))
        {
            butterflytwowords.text = "whats up";
            butterflytwowords.gameObject.SetActive(true);

        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "pengu2"))
        {
            butterflytwowords.gameObject.SetActive(false);

        }
    }
}
