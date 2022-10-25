using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV2 : MonoBehaviour
{
    public float speed;
    public float jumpSpeed = 1;
    private Rigidbody2D rb;

    bool jumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
        }

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed * Time.deltaTime, rb.velocity.y);
            //rb.AddForce(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
            //rb.AddForce(Vector2.right * speed * Time.deltaTime);
        }

        if (jumping == true)
        {
            rb.velocity = Vector2.up * jumpSpeed;
            //rb.AddForce(Vector2.up * jumpSpeed * Time.deltaTime,ForceMode2D.Impulse);
            jumping = false;
        }


    }
}
