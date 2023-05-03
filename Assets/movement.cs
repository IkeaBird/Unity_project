using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public KeyCode moveDown;
    public KeyCode moveUp;
    public KeyCode moveLeft;
    public KeyCode MoveRight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ()
        {

        }


        if (Input.GetKeyDown(moveUp))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
        }
        if (Input.GetKeyDown(moveDown))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -5);
        }
        if (Input.GetKeyDown(moveLeft))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
        }
        if (Input.GetKeyDown(MoveRight))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
        }
    }
}
