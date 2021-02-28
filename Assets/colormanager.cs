using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colormanager : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;

    public GameObject redstairs;
    public GameObject dredstairs;
    public GameObject redbg;

    public GameObject bluestairs;
    public GameObject dbluestairs;
    public GameObject bluebg;

    public GameObject purplestairs;
    public GameObject dpurplestairs;
    public GameObject purplebg;

    public GameObject reaper;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((red.gameObject.GetComponent<clickswitch>().on == true)&& (blue.gameObject.GetComponent<clickswitch>().on == false))
        {
            Debug.Log("red");
            //redstairs.gameObject.GetComponent<SpriteRenderer>().enabled=true;
            //bluestairs.gameObject.SetActive(false);
            //purplestairs.gameObject.SetActive(false);

            //redsstuff
            SpriteRenderer[] sprites = redstairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites.Length; i++)
            {
                sprites[i].enabled = true;
            }

            SpriteRenderer[] sprites4 = dredstairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites4.Length; i++)
            {
                sprites4[i].enabled = true;
            }
            redbg.gameObject.SetActive(true);

            //bluestuff
            SpriteRenderer[] sprites2 = bluestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites2.Length; i++)
            {
                sprites2[i].enabled = false;
            }

            SpriteRenderer[] sprites5 = dbluestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites5.Length; i++)
            {
                sprites5[i].enabled = false;
            }
            bluebg.gameObject.SetActive(false);

            //purplestuff
            SpriteRenderer[] sprites3 = purplestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites3.Length; i++)
            {
                sprites3[i].enabled = false;
            }
            SpriteRenderer[] sprites6 = dpurplestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites6.Length; i++)
            {
                sprites6[i].enabled = false;
            }
            purplebg.gameObject.SetActive(false);




        }
        else if ((blue.gameObject.GetComponent<clickswitch>().on == true)&& (red.gameObject.GetComponent<clickswitch>().on == false))
        {
            Debug.Log("blue");
            //redstairs.gameObject.SetActive(false);
            //bluestairs.gameObject.SetActive(true);
            //purplestairs.gameObject.SetActive(false);
            SpriteRenderer[] sprites = redstairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites.Length; i++)
            {
                sprites[i].enabled = false;
            }
            SpriteRenderer[] sprites4 = dredstairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites4.Length; i++)
            {
                sprites4[i].enabled = false;
            }
            redbg.gameObject.SetActive(false);

            SpriteRenderer[] sprites2 = bluestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites2.Length; i++)
            {
                sprites2[i].enabled = true;
            }
            SpriteRenderer[] sprites5 = dbluestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites5.Length; i++)
            {
                sprites5[i].enabled = true;
            }
            

            bluebg.gameObject.SetActive(true);

            SpriteRenderer[] sprites3 = purplestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites3.Length; i++)
            {
                sprites3[i].enabled = false;
            }
            SpriteRenderer[] sprites6 = dpurplestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites6.Length; i++)
            {
                sprites6[i].enabled = false;
            }
            purplebg.gameObject.SetActive(false);
        }
        else if ((blue.gameObject.GetComponent<clickswitch>().on == true)&& (red.gameObject.GetComponent<clickswitch>().on == true))
        {
            //redstairs.gameObject.SetActive(false);
            //bluestairs.gameObject.SetActive(false);
            //purplestairs.gameObject.SetActive(true);
            Debug.Log("purple");

            SpriteRenderer[] sprites = redstairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites.Length; i++)
            {
                sprites[i].enabled = false;
            }
            SpriteRenderer[] sprites4 = dredstairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites4.Length; i++)
            {
                sprites4[i].enabled = false;
            }
            redbg.gameObject.SetActive(false);

            SpriteRenderer[] sprites2 = bluestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites2.Length; i++)
            {
                sprites2[i].enabled = false;
            }
            SpriteRenderer[] sprites5 = dbluestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites5.Length; i++)
            {
                sprites5[i].enabled = false;
            }
            
            bluebg.gameObject.SetActive(false);


            SpriteRenderer[] sprites3 = purplestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites3.Length; i++)
            {
                sprites3[i].enabled = true;
            }
            SpriteRenderer[] sprites6 = dpurplestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites6.Length; i++)
            {
                sprites6[i].enabled = true;
            }
            purplebg.gameObject.SetActive(true);
        }
        else if ((blue.gameObject.GetComponent<clickswitch>().on == false) && (red.gameObject.GetComponent<clickswitch>().on == false))
        {
            Debug.Log("black");
            //redstairs.gameObject.SetActive(false);
            //bluestairs.gameObject.SetActive(false);
            //purplestairs.gameObject.SetActive(false);

            SpriteRenderer[] sprites = redstairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites.Length; i++)
            {
                sprites[i].enabled = false;
            }

            SpriteRenderer[] sprites4 = dredstairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites4.Length; i++)
            {
                sprites4[i].enabled = false;
            }

            SpriteRenderer[] sprites2 = bluestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites2.Length; i++)
            {
                sprites2[i].enabled = false;
            }

            SpriteRenderer[] sprites5 = dbluestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites5.Length; i++)
            {
                sprites5[i].enabled = false;
            }
            bluebg.gameObject.SetActive(false);

            SpriteRenderer[] sprites3 = purplestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites3.Length; i++)
            {
                sprites3[i].enabled = false;
            }
            SpriteRenderer[] sprites6 = dpurplestairs.GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < sprites6.Length; i++)
            {
                sprites6[i].enabled = false;
            }

            redbg.gameObject.SetActive(false);
            bluebg.gameObject.SetActive(false);
            purplebg.gameObject.SetActive(false);
            reaper.gameObject.SetActive(true);
        }



    }
}
