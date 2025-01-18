using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Player player;
    public Rigidbody2D rb;
    float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2 (player.transform.position.x, transform.position.y);
        rb.AddForce((player.transform.position- transform.position).normalized * Speed, ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector2 LeftVel = new Vector2(-0.8f, 0);
            float distance = Vector2.Distance(new Vector2(transform.position.x, 0), new Vector2(collision.gameObject.transform.position.x, 0));
            if (distance == 0)
                return;
                
            LeftVel *= distance / collision.transform.localScale.x ;
            if (transform.position.x > collision.transform.position.x)
                LeftVel = -LeftVel;
            LeftVel.y = 1;
            rb.velocity = new Vector2(0, 0);
            rb.AddForce(LeftVel* Speed, ForceMode2D.Impulse);
        }
        if(collision.gameObject.tag == "Brick")
        {
            Destroy(collision.gameObject);
        }
    }
}
