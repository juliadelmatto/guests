using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class sequence : MonoBehaviour
{
    public static sequence instance;
    public bool basicroom = false;
    public bool pinkroom = false;
    public bool birdguy=false;
    public bool beach=false;
    private bool seenbasic = false;
    public GameObject instructions;
    public int charactersvisited = 0;

    public bool hasplayed = false;
    public AudioClip doorshut;
    AudioSource audioSource;
    //public AudioSource audioData;
    //public AudioClip song;

    private void Awake()
    {
        if (gameObject.name!="SequenceManager")
        {
            return;
        }


        DontDestroyOnLoad(this.gameObject);


        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        //if (basicroom)
        //{
            
        //    //print("sequence true");
        //}


        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "basicroom")
        {
            
            seenbasic = true;
            basicroom = true;
        }
        if (sceneName == "beach")
        {
            beach = true;
        }
        if (sceneName == "house")
        {
            birdguy = true;
        }
        if (sceneName == "pinkgirl")
        {
            pinkroom = true;
        }

        if ((seenbasic == false))
        {
            print("its false");
            instructions.SetActive(true);
        }
    }



}
