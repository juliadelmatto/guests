using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textRecognitionScript : MonoBehaviour
{
    public GameObject textBox;
    public string textToCheck;
    bool activated;
    // Start is called before the first frame update
    void Start()
    {
        activated = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (textBox.GetComponent<Text>().text==textToCheck)
        {
            activated = true;
            Debug.Log("check!");
        }
    }
}
