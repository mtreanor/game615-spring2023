using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController cc;

    public Animator animator;
    public Animator menuAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        transform.Rotate(0, 80 * hAxis * Time.deltaTime, 0);

        if (Mathf.Abs(vAxis) > 0)
        {
            animator.SetBool("walking", true);
            menuAnimator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
            menuAnimator.SetBool("walking", false);
        }

        cc.Move(transform.forward * 5 * vAxis * Time.deltaTime);
        //transform.Translate(transform.forward * 5 * Time.deltaTime);
    }
}
