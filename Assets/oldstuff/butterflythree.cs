using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterflythree : MonoBehaviour
{
    public TextMesh butterflythreewords;

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
            butterflythreewords.text = "hi";
            butterflythreewords.gameObject.SetActive(true);

        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "pengu2"))
        {
            butterflythreewords.gameObject.SetActive(false);

        }
    }
}
