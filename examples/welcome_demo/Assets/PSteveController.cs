using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSteveController : MonoBehaviour
{
    Rigidbody rb;

    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.useGravity = true;
        }

        if (gameObject.transform.position.y < -10)
        {
            gameObject.transform.position = startPos;
        }
    }
}
