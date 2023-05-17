using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public KeyCode moveDown;
    public KeyCode moveUp;
    public KeyCode moveLeft;
    public KeyCode moveRight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if ()
        //{

        //}


        if (Input.GetKeyDown(moveUp))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);
        }
        if (Input.GetKeyDown(moveDown))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -10);
        }
        if (Input.GetKeyDown(moveLeft))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);
        }
        if (Input.GetKeyDown(moveRight))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
        }
    }
}
