using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class diagonalMovement : MonoBehaviour
{
    Vector2 startVector;
    public float xOffset = 0;
    public float angleconstant;
    // Start is called before the first frame update

    public Sprite birdguyopen;
    public Sprite pinkgirlopen;
    public Sprite beachopen;
    public Sprite closedsprite;

    public int doornum = 1;

    public sequence s;
    void Start()
    {

        

        if (GameObject.Find("SequenceManager"))
        {
            s = GameObject.Find("SequenceManager").GetComponent<sequence>();
        } else
        {
            s = gameObject.AddComponent<sequence>();
            s.enabled = false;
        }


        startVector = transform.position;

       
    }

    // Update is called once per frame
    void Update()
    {
        if (xOffset> 31.62639f)
        {
            xOffset = -0.5224943f;
        }
        if (xOffset< -0.5224943f)
        {
            xOffset = 31.62639f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            // xOffset -= xPosFunc(xOffset);
            xOffset += 0.03f * (1+xOffset);
        } else if (Input.GetKey(KeyCode.S))
        {
            xOffset -= 0.03f * (1+xOffset);
            // xOffset += xPosFunc(xOffset);
        }
        transform.position =
            new Vector2(
                startVector.x+(xOffset*Mathf.Sign(transform.position.x-1.05f)),
                startVector.y+yPos(xOffset));

        transform.localScale = new Vector2(1 + 1 * xOffset, 1 + 1 * xOffset);
    }
    //-0.6224943
    //31.62639
    float yPos(float xPos)
    {
        return (xPos * -angleconstant);
    }

    float xPosFunc(float xPos)
    {
        return (xPos * angleconstant * 0.01f);
    }


    private void OnMouseOver()
    {
        print("lskdjf");
        if (doornum == 1)
        {
            if (s.pinkroom == false)
            {
                GetComponent<SpriteRenderer>().sprite = pinkgirlopen;
            }
            else
            {
                doornum = 2;
            }
        }
        if (doornum == 2)
        {
            if (s.birdguy == false)
            {
                GetComponent<SpriteRenderer>().sprite = birdguyopen;
            }
            else
            {
                doornum = 3;
            }
        }
        if (doornum == 3)
        {
            if (s.beach == false)
            {
                GetComponent<SpriteRenderer>().sprite = beachopen;
            }
            else
            {
                doornum = 1;
            }
        }

    }

    private void OnMouseDown()
    {
        print("yes");
            if (doornum == 1)
            {   
            if (s.pinkroom == false)
            {
                SceneManager.LoadScene("pinkgirl");
            }
            else
            {
                doornum = 2;
            }
        }
        if (doornum == 2)
        {
            if (s.birdguy == false)
            {
                SceneManager.LoadScene("house");
            }
            else
            {
                doornum = 3;
            }
        }
        if (doornum == 3)
        {
            if (s.beach == false)
            {
                SceneManager.LoadScene("beach");
            }
            else
            {
                doornum = 1;
            }
        }
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = closedsprite;
    }


}
