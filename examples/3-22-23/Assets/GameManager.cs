using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    float health = 100;

    public TMP_Text healthText;
    public Image healthImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireButtonClicked()
    {
        health = health - 10;
        healthText.text = health.ToString();

        healthImage.fillAmount = health / 100;
    }
}
