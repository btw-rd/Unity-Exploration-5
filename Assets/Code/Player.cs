using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        GetComponent<Transform>().GetChild(0).GetComponent<Rigidbody2D>().centerOfMass = new Vector3(0, 0, 0);
        GetComponent<Transform>().GetChild(1).GetComponent<Rigidbody2D>().centerOfMass = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Hit right flipper
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().GetChild(0).GetComponent<Rigidbody2D>().MoveRotation(-60f);
        }
        else
        {
            GetComponent<Transform>().GetChild(0).GetComponent<Rigidbody2D>().MoveRotation(10f);
        }

        // Hit left flipper
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().GetChild(1).GetComponent<Rigidbody2D>().MoveRotation(240f);
        }
        else
        {
            GetComponent<Transform>().GetChild(1).GetComponent<Rigidbody2D>().MoveRotation(170f);
        }
    }
}
