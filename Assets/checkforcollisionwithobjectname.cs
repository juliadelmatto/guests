using UnityEngine;

public class checkforcollisionwithobjectname : MonoBehaviour
{

    public string bodyname;
    public bool colliding = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        Debug.Log("COLLISION");
        if (col.gameObject.name == bodyname)
        {
            colliding = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == bodyname)
        {
            //colliding = false;
        }
    }
}
