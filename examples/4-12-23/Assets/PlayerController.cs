using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D box;

    public Camera cam;

    public LayerMask mask;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        box = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnGround())
        {
            rb.AddForce(Vector2.up * 1000);
        }

        if (Input.GetKeyUp(KeyCode.Space) && rb.velocity.y > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }

        float hAxis = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(10 * hAxis, rb.velocity.y);

        //Vector2 vectorToCamera = cam.ScreenToWorldPoint(Input.mousePosition) - gameObject.transform.position;
        //vectorToCamera = vectorToCamera.normalized * 5;
        //rb.velocity = new Vector2(vectorToCamera.x, rb.velocity.y);

    }

    bool OnGround()
    {
        RaycastHit2D hit = Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0, Vector2.down, 0.1f, mask);

        //if (hit.collider == null)
        //{
        //    return false;
        //}
        //return true;

        return hit.collider != null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I collided with something!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Just collided with " + collision.gameObject.name);
    }
}
