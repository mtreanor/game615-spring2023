using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrounfScript : MonoBehaviour
{
    public GameObject carPrefab;
    GameObject car;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (car != null)
            {
                Rigidbody rb = car.GetComponent<Rigidbody>();
                rb.AddForce(car.transform.forward * 1000);
            }
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // if we get in this if statement we clicked on the ground)
            Vector3 carPosition = gameObject.transform.position;
            car = Instantiate(carPrefab);
            car.transform.position = carPosition;
        }
    }
}
