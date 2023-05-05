using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    float spacing = 1.5f;

    int numCubes = 200;

    Rigidbody firstCube;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numCubes; i = i + 1)
        {

            GameObject cube = Instantiate(cubePrefab, transform.position, transform.rotation);
            Renderer cubeRenderer = cube.GetComponentInChildren<Renderer>();

            if (firstCube == null)
            {
                firstCube = cube.GetComponent<Rigidbody>();
            }

            cubeRenderer.material.color = Color.HSVToRGB((float)i / numCubes, 0.4f, 1.0f);

            transform.Rotate(0, Random.Range(-10, 10), 0);
            transform.Translate(transform.forward * spacing);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            firstCube.AddForce(firstCube.transform.forward * 1000);
        }
    }
}
