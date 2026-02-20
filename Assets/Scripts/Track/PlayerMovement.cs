using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    float horizontalInput;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-20 *Time.deltaTime, 0, 0);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(20 * Time.deltaTime, 0, 0);

        }
       
    }
}
