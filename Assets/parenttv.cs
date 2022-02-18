using UnityEngine;

public class parenttv : MonoBehaviour
{
    public GameObject tv1;
    public GameObject tv2;
    public GameObject tv3;
    public GameObject tv4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tv1.gameObject.GetComponent<checkforcollisionwithobjectname>().colliding == true && tv2.gameObject.GetComponent<checkforcollisionwithobjectname>().colliding == true && tv3.gameObject.GetComponent<checkforcollisionwithobjectname>().colliding == true && tv4.gameObject.GetComponent<checkforcollisionwithobjectname>().colliding == true)
        {
            Debug.Log("PUZZLE SOLVED!!");
            //do this when puzzle solved
        }
    }
}
