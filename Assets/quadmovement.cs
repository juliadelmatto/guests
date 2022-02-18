using UnityEngine;

public class quadmovement : MonoBehaviour
{
    public enum Direction { up, down, left, right };
    public Direction direction;

    public float speed;
    Rigidbody2D rb;

    bool holdingDown;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (direction)
        {
            case Direction.left:

                if (Input.GetKey(KeyCode.A))
                {
                    rb.velocity = new Vector2(rb.velocity.x, -speed);
                    //transform.position(Vector3.up, -10.0f * Time.deltaTime);
                }
                else
                {
                    rb.velocity = new Vector2(rb.velocity.x, 0);
                }
                break;

            case Direction.up:

                if (Input.GetKey(KeyCode.W))
                {
                    rb.velocity = new Vector2(rb.velocity.x, -speed);
                    //transform.position(Vector3.up, -10.0f * Time.deltaTime);
                }
                else
                {
                    rb.velocity = new Vector2(rb.velocity.x, 0);
                }
                break;
            case Direction.right:

                if (Input.GetKey(KeyCode.D))
                {
                    rb.velocity = new Vector2(rb.velocity.x, -speed);
                    //transform.position(Vector3.up, -10.0f * Time.deltaTime);
                }
                else
                {
                    rb.velocity = new Vector2(rb.velocity.x, 0);
                }
                break;
            case Direction.down:

                if (Input.GetKey(KeyCode.S))
                {
                    rb.velocity = new Vector2(rb.velocity.x, -speed);
                    //transform.position(Vector3.up, -10.0f * Time.deltaTime);
                }
                else
                {
                    rb.velocity = new Vector2(rb.velocity.x, 0);
                }
                break;







        }


        //if ((Input.GetKey(KeyCode.W)))
        //{
        //    rb.velocity = new Vector2(rb.velocity.x, -speed);
        //    //transform.position(Vector3.up, -10.0f * Time.deltaTime);
        //}
        //else
        //{
        //    rb.velocity = new Vector2(rb.velocity.x, 0);
        //}

        //switch (direction)
        //{
        //    case Direction.left:

        //        if (Input.GetKeyDown(KeyCode.A))
        //        {

        //            rb.velocity = new Vector2(rb.velocity.x, -speed);
        //        }
        //        break;


        //}
    }
}
