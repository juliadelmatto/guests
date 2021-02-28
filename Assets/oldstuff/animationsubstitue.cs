using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationsubstitue : MonoBehaviour
{
    public string whatisitdoing;
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
        //find object "words" == public game
        GameObject.Find("words").GetComponent<TextMesh>().text = whatisitdoing;
    }

    private void OnMouseExit()
    {
        //find object "words" == public game
        GameObject.Find("words").GetComponent<TextMesh>().text = "";
    }
}
