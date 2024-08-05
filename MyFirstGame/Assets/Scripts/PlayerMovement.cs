
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 2000f;
   


    //We marked this as "Fixed" Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Add a force of 2000 on the z axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0,0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
