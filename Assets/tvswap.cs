using UnityEngine;

public class tvswap : MonoBehaviour
{
    //public Sprite originalsprite;
    public GameObject changeto;

    public bool on = true;
    public bool off = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (off)
        {

        }
        if (on)
        {

        }
    }

    private void OnMouseDown()
    {
        // Debug.Log(gameObject.name);
        //Debug.Log("sd");
        if (on)
        {
            changeto.SetActive(false);
            //GetComponent<SpriteRenderer>().sprite = changeto;
            //on = false;
            off = true;
            on = false;
            return;

        }
        if (off)
        {
            changeto.SetActive(true);
            //GetComponent<SpriteRenderer>().sprite = originalsprite;
            off = false;
            on = true;
            return;
            //on = true;

        }

    }
}
