<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
=======
>>>>>>> Stashed changes
using UnityEngine;

public class script : MonoBehaviour
{
<<<<<<< Updated upstream
    public float speed;
    private float move;
    private float updown;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=  GetComponent<Rigidbody2D>();
=======

    public float speed;
    private float movex;
    private float movey;

    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        move = Input.GetAxis("Horizontal");
        updown = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(move * speed, updown * speed);

        if (Input.GetKey(KeyCode.E))
        {
            print("interacting");
        }
=======
        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector2(movex * speed, movey * speed);
>>>>>>> Stashed changes
    }
}
