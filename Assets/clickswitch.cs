using UnityEngine;

public class clickswitch : MonoBehaviour
{
    public Sprite originalsprite;
    public Sprite changeto;

    public bool on = true;
    public bool off = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        Debug.Log("Name = " + hit.collider.name);
        //        Debug.Log("Tag = " + hit.collider.tag);
        //        Debug.Log("Hit Point = " + hit.point);
        //        Debug.Log("Object position = " + hit.collider.gameObject.transform.position);
        //        Debug.Log("--------------");
        //    }
        //}


    }

    private void OnMouseDown()
    {
        // Debug.Log(gameObject.name);
        //Debug.Log("sd");
        if (on)
        {
            GetComponent<SpriteRenderer>().sprite = changeto;
            //on = false;
            off = true;
            on = false;
            return;

        }
        if (off)
        {
            GetComponent<SpriteRenderer>().sprite = originalsprite;
            off = false;
            on = true;
            return;
            //on = true;

        }

    }
}
