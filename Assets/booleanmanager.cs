using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class booleanmanager : MonoBehaviour
{

    public static booleanmanager instance;

    public bool pinkgirl = false;
    public bool emogirl = false;
    public bool birdguy = false;

    private void Awake()
    {
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
       

    }

    // Update is called once per frame
    void Update()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "beach")
        {
            pinkgirl = true;
        }
        if (sceneName == "house")
        {
            birdguy = true;
        }
        if (sceneName == "cave")
        {
            emogirl = true;
        }
    }
}
