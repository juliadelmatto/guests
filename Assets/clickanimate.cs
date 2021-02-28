using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickanimate : MonoBehaviour
{
    //public GameObject thisobject;
    //private Animator yourAnimator;
    //protected Animation anim;
    //public Animation a;
    //public Sprite newsprite;
    public GameObject eyebg;
    float timeLeft = 0.3f;
    private bool timergo = false;
    //public Animation anim;

    //protected void Awake()
    //{
    //    anim = GetComponent<Animation>();
    //}
    void Start()
    {
        //yourAnimator = thisobject.GetComponent<Animator>();
        
    }

    void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
            
            
        //}
        if (timergo)
        {
            timeLeft -= Time.deltaTime;
        }
        if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("exit"))
        {
            Debug.Log("exit");
           
        }

        //if (anim["emptyeyeblink"].normalizedTime >= .5)
        //{
        //    eyebg.SetActive(true);
        //}
        if (timeLeft < 0)
        {
            eyebg.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        //yourAnimator.animation.Play("eye1_1");
        // yourAnimator.GetComponent<Animator>().Play("eye2");
        //this.GetComponent<Animation>().Play("eye2");
        this.GetComponent<Animator>().SetBool("clickbool", true);
        timergo = true;
    }
}
