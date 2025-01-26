using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Unity.Multiplayer.Center.Common.Analytics;
public class Customer : MonoBehaviour
{
    private PlayerStat playerStat;

    public List<Food> myOrder;
    /// <summary>
    /// The customer wait time for order
    /// </summary>
    public float BubbleTime = 5;
    public GameObject Seat;
    public float moveSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStat = FindAnyObjectByType<PlayerStat>();

        string myOrders = "My orders are ";
        for (int i = 0; i < myOrder.Count; i++)
        {
            if (i != 0)
                myOrders += ", ";
            myOrders += myOrder[i].Name;

        }
        print(myOrders);
        BubbleTime = 100;
    }

    bool isOrderCompleted(Food PlayerChoice, Food food)
    {
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

    public void interactCustomer()
    {
        if (myOrder.Count > 0)
        {
            Debug.Log("S pressed");

            for (int i = 0; i < myOrder.Count; i++)
            {
                // Serve the customer:
                if (isOrderCompleted(Everything.Instance.PlayerChoice, myOrder[i]))
                {
                    playerStat.AddCurrency(myOrder[i].profit);
                    myOrder.RemoveAt(i--);
                    Everything.Instance.PlayerChoice.Recipe.Clear();
                    break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (myOrder.Count > 0)
            BubbleTime -= Time.deltaTime;

        if(BubbleTime<= 0)
        {
            Destroy(gameObject);
            SeatsManager.instance.SetSeatAvailable(Seat);
        }
        float distance = Vector3.Distance(transform.position, Seat.transform.position);
        if (distance < 1 && transform.position != Seat.transform.position)
        {
            transform.position = Seat.transform.position;
        }

        if (transform.position.x < Seat.transform.position.x && Mathf.Abs(transform.position.x-Seat.transform.position.x) > 0.1f )
        {
            transform.position += new Vector3(1, 0) * moveSpeed * Time.deltaTime;
        }
        else if (transform.position.x > Seat.transform.position.x && Mathf.Abs(transform.position.x - Seat.transform.position.x) > 0.1f)
        {
            transform.position -= new Vector3(1, 0) * moveSpeed * Time.deltaTime;
        }else if (transform.position.y < Seat.transform.position.y && Mathf.Abs(transform.position.y - Seat.transform.position.y) > 0.1f)
        {

            transform.position += new Vector3(0, 1) * moveSpeed * Time.deltaTime;
        }
        else if (transform.position.y > Seat.transform.position.y && Mathf.Abs(transform.position.y - Seat.transform.position.y) > 0.1f)
        {

            transform.position -= new Vector3(0, 1) * moveSpeed * Time.deltaTime;
        }
    }
}
