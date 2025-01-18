using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5;
    Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        rb.AddForce(new Vector2(0, -1) * speed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Vector2 leftVel = new Vector2(0.8f, 0);
            float distance = transform.position.x - collision.transform.position.x;
            if (distance == 0)
                return;
            leftVel *= distance / collision.transform.localScale.x;
            rb.velocity = new Vector2(0,0);
            leftVel.y = 1;
            rb.AddForce(leftVel * speed, ForceMode2D.Impulse);
        }
        if(collision.gameObject.tag == "Brick")
        {
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = startPosition;
        rb.velocity = new Vector2(0, 0);
        rb.AddForce(new Vector2(0, -1) * speed, ForceMode2D.Impulse);
    }
}
