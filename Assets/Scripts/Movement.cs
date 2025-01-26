
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private float movex;
    private float movey;


    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        SpriteRenderer ok = GetComponent<SpriteRenderer>();

        if (transform.position.y > -2)
        {
            ok.sortingOrder = 3; // Render on top
        }
        else
        {
            ok.sortingOrder = 6; // Render below
        }

        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector2(movex * speed, movey * speed);
    }
}
