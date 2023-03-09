using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        transform.Translate(transform.forward * vAxis * 5 * Time.deltaTime, Space.World);
        transform.Rotate(0, hAxis * 70 * Time.deltaTime, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("ball"))
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().incScore();
            Destroy(other.gameObject);
        }
    }
}
