using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text dynamicText;
    int score = 0;
    public GameObject ballPrefab;

    float rainTimer = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Every 0.5 second create a ball and position it randomly over the ground
        rainTimer -= Time.deltaTime;
        if (rainTimer < 0)
        {
            // reset the timer variable
            rainTimer = 0.5f;

            Vector3 pos = new Vector3(Random.Range(-5, 5), 10, Random.Range(-5, 5));
            Instantiate(ballPrefab, pos, Quaternion.identity);
        }
    }


    // This method will be called from PlayerController when they collide with a "ball"
    public void incScore()
    {
        score++;
        dynamicText.text = score.ToString();
    }
}
