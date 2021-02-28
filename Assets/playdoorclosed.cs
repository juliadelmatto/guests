using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playdoorclosed : MonoBehaviour
{

    public AudioClip sound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound, 0.5F);
    }

    // Update is called once per frame
    void Update()
    {
        //if (hasplayed == false)
        //{
        //    audioSource.PlayOneShot(doorshut, 0.5F);
        //    hasplayed = true;
        //}
    }
}
