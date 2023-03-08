using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "My name is Mike.";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score = score + 1;
            scoreText.text = score.ToString(); 
        }
        
    }

    public void resetScore()
    {
        Debug.Log("this happened!");
        score = 0;
        scoreText.text = score.ToString();
    }

    public void shootPizzSteve()
    {
        GameObject[] pSteves = GameObject.FindGameObjectsWithTag("pizza");
        for (int i = 0; i < pSteves.Length; i = i + 1)
        {
            pSteves[i].GetComponent<Rigidbody>().AddForce(pSteves[i].transform.forward * 1000);
           
        }
    }
}
