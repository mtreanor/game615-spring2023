using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public UnitScript selectedUnit;

    public TMP_Text nameText;

    public Animator namePanelAnimator;

    public Sprite dogPaw;
    public Sprite catPaw;

    public Image pawImage;

    public Image manaMeterImage;

    public Transform manaMeterTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit) == false)
            {

                if (selectedUnit != null)
                {
                    selectedUnit.selected = false;
                    selectedUnit.bodyRend.material.color = selectedUnit.defaultColor;

                    selectedUnit = null;

                    namePanelAnimator.SetTrigger("fadeOut");
                }
            }
            else
            {
                if (selectedUnit != null) {
                    selectedUnit.nma.SetDestination(hit.point);
                }
            }

        }
    }

    public void SelectUnit(UnitScript unit)
    {
        if (selectedUnit == null)
        {
            namePanelAnimator.SetTrigger("fadeIn");
        }

        selectedUnit = unit;
        nameText.text = unit.unitName;
        if (unit.isCat)
        {
            pawImage.sprite = catPaw;
        }
        else
        {
            pawImage.sprite = dogPaw;
        }

        manaMeterImage.fillAmount = unit.manaAmount / unit.maxMana;

        Vector3 pos = unit.transform.position + Vector3.up * 2.5f;
        manaMeterTransform.position = Camera.main.WorldToScreenPoint(pos);
    }
}
