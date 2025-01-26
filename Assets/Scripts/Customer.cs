using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Customer : MonoBehaviour
{
    public List<string> myOrder;
    /// <summary>
    /// The customer wait time for order
    /// </summary>
    public float BubbleTime = 5;
    public GameObject Seat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string myOrders = "My orders are ";
        for (int i = 0; i < myOrder.Count; i++)
        {
            if (i != 0)
                myOrders += ", ";
            myOrders += myOrder[i];

        }
        print(myOrders);
        transform.position = Seat.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        BubbleTime -= Time.deltaTime;
        if(BubbleTime<= 0)
        {
            Destroy(gameObject);
            SeatsManager.instance.SetSeatAvailable(Seat);
        }    
    }



}
