using UnityEngine;

public class sidebar : MonoBehaviour
{

    public bool hovering = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseOver()
    {
        hovering = true;
    }
    void OnMouseExit()
    {
        hovering = false;
    }
}
