using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class whichhallway : MonoBehaviour
{
    public sequence s;

    // Start is called before the first frame update
    void Start()
    {

        if (GameObject.Find("SequenceManager"))
        {
            s = GameObject.Find("SequenceManager").GetComponent<sequence>();
        }
        else
        {
            s = gameObject.AddComponent<sequence>();
            s.enabled = false;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print("press");
        if ((s.charactersvisited ==1) || (s.charactersvisited == 2))
        {
            s.charactersvisited += 1;
            SceneManager.LoadScene("hallway2");
        }
        else if(s.charactersvisited==3)
        {
            SceneManager.LoadScene("hallway3");
        }
        
    }
}
