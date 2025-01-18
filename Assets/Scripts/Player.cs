using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos;
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.y = transform.position.y;
        
        transform.position = MousePos;
    }
}
