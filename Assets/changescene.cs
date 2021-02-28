using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public string scenename;
    //public Vector2 camerago;
    private int wait = 50;

    public Vector2 destination;
    Vector3 dest2;

    public bool playasoundwhenmousedover = false;
    private bool hasPlayed = false;

    public AudioClip sound;
    AudioSource audioSource;

    //// Start is called before the first frame update
    void Start()
    {
        dest2 = new Vector3(destination.x, destination.y, -10);
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        wait--;
    }

    private void OnMouseDown()
    {
        //Debug.Log("clicked frog");
        //if (currentscene != "evilboy") { 
       /*
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position,
                new Vector3(destination.x, destination.y, -10),
                30f);*/
       // }
       if(wait<0)
        SceneManager.LoadScene(scenename);
//        Camera.main.GetComponent<camera>().sceneChange(dest2);


        

    }

    private void OnMouseOver()
    {
        if (playasoundwhenmousedover)
        {
            if (!hasPlayed)
            {
                audioSource.PlayOneShot(sound, 0.5F);
                hasPlayed = true;
            }
            
        }

    }
}

