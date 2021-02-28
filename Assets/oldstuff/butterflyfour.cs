using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterflyfour : MonoBehaviour
{
    public TextMesh butterflyfourwords;
    
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
            butterflyfourwords.text = "hey";
            butterflyfourwords.gameObject.SetActive(true);

        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "pengu2"))
        {
            butterflyfourwords.gameObject.SetActive(false);

        }
    }

    
}
