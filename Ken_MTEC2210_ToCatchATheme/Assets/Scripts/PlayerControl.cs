using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5; // declaring variable and initializing as 5 // not putting anyything will default to 0
    //public float health = 10;
    //public Transform otherObject;    // Start is called before the first frame update
    void Start()
    {
        //speed = 5; // initializing

    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        
        /* //Not a good version of coding movement
        if (Input.GetKeyDown(KeyCode.A))
        {
            speed = -5;
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            speed = 5;
        } else
        {
            speed = 0;
        }
        */

         //Debug.Log("xMove" + xMove);
         //transform.Translate(speed * Time.deltaTime, 0, 0);
        transform.Translate(xMove * speed * Time.deltaTime, 0, 0);
         //transform.Translate(1f * Time.deltaTime, 0, 0);
         //transform.Translate(0.1f, 0, 0);
         //transform.position = new Vector3(0,0,0);

    }
}
