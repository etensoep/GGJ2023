using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello, world");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,5,0);
        }

        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-10,0,0);
        }


        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(10,0,0);
        }
    }
}
