
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

        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector2(movex * speed, movey * speed);
    }
}
