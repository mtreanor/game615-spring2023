using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitScript : MonoBehaviour
{
    public string unitName;

    public bool isCat;

    public Renderer bodyRend;
    public Color hoverColor;
    public Color selectedColor;
    public Color defaultColor;

    public float manaAmount;
    public float maxMana = 100f;

    public bool selected = false;

    public NavMeshAgent nma;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = bodyRend.material.color;

        GameObject gmObj = GameObject.Find("GameManagerObject");
        gm = gmObj.GetComponent<GameManager>();

        nma = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        gm.manaMeterImage.fillAmount = manaAmount / maxMana;
        Vector3 pos = transform.position + Vector3.up * 2.5f;
        gm.manaMeterTransform.position = Camera.main.WorldToScreenPoint(pos);
        gm.manaMeterTransform.gameObject.SetActive(true);


        if (selected == false)
        {
            bodyRend.material.color = hoverColor;
        }
    }

    private void OnMouseExit()
    {
        gm.manaMeterTransform.gameObject.SetActive(false);
        if (selected == false)
        {
            bodyRend.material.color = defaultColor;
        }
    }

    private void OnMouseDown()
    {
        if (gm.selectedUnit != null)
        {
            // if we're here, something was already selected!
            // 1. Deselect it
            this.gm.selectedUnit.selected = false;
            gm.selectedUnit.bodyRend.material.color = gm.selectedUnit.defaultColor;
        }
        // 2. Select me!
        selected = true;
        bodyRend.material.color = selectedColor;

        gm.SelectUnit(this);
    }
}
