using UnityEngine;

public class looping : MonoBehaviour
{
    public float loopx = 15f;
    public float loopy = 7f;
    public bool abletoloop = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (abletoloop)
        {
            //loop y
            if (transform.position.y > loopy)
            {
                transform.position = new Vector2((transform.position.x), -loopy + 1f);
            }

            if (transform.position.y < -(loopy - 1f))
            {
                transform.position = new Vector2((transform.position.x), (loopy - 1f));
            }


            //loop x
            if (transform.position.x > loopx)
            {
                transform.position = new Vector2(-loopx + 1f, (transform.position.y));
            }

            if (transform.position.x < -(loopx - 1f))
            {
                transform.position = new Vector2((loopx - 1f), (transform.position.y));
            }

        }
    }
}
