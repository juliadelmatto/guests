using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    public static camera instance;

    public bool sceneStart;
    public Vector3 newScenePos;
    string pastSceneName;

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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneStart)
        {
            if (SceneManager.GetActiveScene().name != pastSceneName)
            {
                transform.position = newScenePos;
                sceneStart = false;
            }
        }
    }

    public void sceneChange(Vector3 newPos)
    {
        sceneStart = true;
        pastSceneName = SceneManager.GetActiveScene().name;
        newScenePos = newPos;
    }
}
