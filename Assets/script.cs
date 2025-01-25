using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class script : MonoBehaviour
{
    public float speed;
    private float move;
    private float updown;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        updown = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(move * speed, updown * speed);

        if (Input.GetKey(KeyCode.E))
        {
            print("interacting");
        }
    }
}
