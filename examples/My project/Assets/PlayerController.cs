using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 camForward = Camera.main.transform.forward;
        camForward.y = 0;
        camForward = camForward.normalized;
        camForward.z *= hAxis * 3;
        camForward.x *= vAxis * 3;
        rb.AddForce(camForward);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 2f);
    }
}
