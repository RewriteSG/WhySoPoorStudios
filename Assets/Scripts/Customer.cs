using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Customer : MonoBehaviour
{
    public List<Food> myOrder;
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
            myOrders += myOrder[i].Name;

        }
        print(myOrders);
        transform.position = Seat.transform.position;

        BubbleTime = 100;
    }

    bool isOrderCompleted(Food PlayerChoice)
    {
        Food food = myOrder[0];
        if (PlayerChoice.Recipe.Count != food.Recipe.Count)
        {
            return false;
        }
        else
        {
            bool checkifcorrectorder = true;
            for (int i = 0; i < PlayerChoice.Recipe.Count; i++)
            {
                if (PlayerChoice.Recipe[i] != (food.Recipe[i]))
                {
                    checkifcorrectorder = false;
                    break;
                }
            }
            if (!checkifcorrectorder)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && myOrder.Count > 0)
        {
            Debug.Log("S pressed");
            // Serve the customer:
            if (isOrderCompleted(Everything.Instance.PlayerChoice))
            {
                myOrder.RemoveAt(0);
            }
        }

        if (myOrder.Count > 0)
            BubbleTime -= Time.deltaTime;

        if(BubbleTime<= 0)
        {
            Destroy(gameObject);
            SeatsManager.instance.SetSeatAvailable(Seat);
        }    
    }
}
