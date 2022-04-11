using UnityEngine;

public class floatingwords : MonoBehaviour
{
    public Sprite emptysprite;
    public GameObject sidebar;

    bool hover;

    //first set sprites
    public GameObject text1;
    public Sprite text1sprite;



    //first thing is to find the first text and change it
    private bool text1changed = false;
    private bool phase1 = true;
    //sencond thing is to scrool over the side bar for "no" to appear
    private bool readyforno = false;
    public GameObject no;
    //third thing is weve moved and changed the text, to find second text
    public Sprite text2sprite;
    private bool phase2 = false;
    private bool text2changed = false;
    private bool readyforbody = false;
    public GameObject body;

    //
    public Sprite text3sprite;
    private bool phase3 = false;
    private bool readyforim = false;
    private bool text3changed = false;
    public GameObject im;

    private bool phase4 = false;
    public GameObject girl;
    public GameObject door;
    public GameObject otherimnobody;
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hover = sidebar.GetComponent<sidebar>().hovering;
        // Debug.Log(hover);


        Vector3 mousePos = Input.mousePosition;
        // Debug.Log(mousePos.x);
        if (readyforno)
        {
            //ifmouse scrolls over the sidebar
            if (hover == true)
            {
                //set no to true
                SetSomethingintheSideBarToTrue(no);

                //set one to dark, move it
                GetComponent<SpriteRenderer>().sprite = emptysprite;
                transform.position = new Vector3(-2f, -3.5f, 0f);
                phase1 = false;
                phase2 = true;
                readyforno = false;
            }
        }

        if (readyforbody)
        {
            if (hover == true)
            {
                SetSomethingintheSideBarToTrue(body);

                GetComponent<SpriteRenderer>().sprite = emptysprite;
                //for now its in the same place
                transform.position = new Vector3(-4f, -3.5f, 0f);
                phase2 = false;
                phase3 = true;
                readyforbody = false; ;
            }
        }
        if (readyforim)
        {
            if (hover == true)
            {
                SetSomethingintheSideBarToTrue(im);
                GetComponent<SpriteRenderer>().sprite = emptysprite;
                phase3 = false;
                readyforim = false;

            }
        }
        if (phase1 == false && phase2 == false && phase3 == false && hover == false)
        {
            //girl stuff!!
            girl.SetActive(true);
            door.SetActive(true);
            //  portal.SetActive(true);

            no.SetActive(false);
            body.SetActive(false);
            im.SetActive(false);
            GetComponent<SpriteRenderer>().sprite = null;
            otherimnobody.SetActive(true);
        }

    }

    void OnMouseOver()
    {
        if (phase1)
        {
            if (text1changed == false)
            {
                GetComponent<SpriteRenderer>().sprite = text1sprite;
            }
        }
        if (phase2)
        {
            if (text2changed == false)
            {
                GetComponent<SpriteRenderer>().sprite = text2sprite;
            }
        }
        if (phase3)
        {
            if (text3changed == false)
            {
                GetComponent<SpriteRenderer>().sprite = text3sprite;

            }
        }

    }

    void OnMouseExit()
    {
        if (phase1)
        {
            if (text1changed == false)
            {
                GetComponent<SpriteRenderer>().sprite = emptysprite;
            }
        }
        if (phase2)
        {
            if (text2changed == false)
            {
                GetComponent<SpriteRenderer>().sprite = emptysprite;
            }
        }
        if (phase3)
        {
            if (text3changed == false)
            {
                GetComponent<SpriteRenderer>().sprite = emptysprite;
            }
        }
    }
    void OnMouseDown()
    {
        if (phase1)
        {
            GetComponent<SpriteRenderer>().sprite = text1sprite;
            text1changed = true;
            readyforno = true;
        }

        if (phase2)
        {
            GetComponent<SpriteRenderer>().sprite = text2sprite;
            text2changed = true;
            readyforbody = true;
        }
        if (phase3)
        {
            GetComponent<SpriteRenderer>().sprite = text3sprite;
            text3changed = true;
            readyforim = true;
        }
        //Debug.Log("hello");

    }

    void SetSomethingintheSideBarToTrue(GameObject x)
    {
        x.SetActive(true);
    }

}
