using UnityEngine;
using UnityEngine.Sprites;
public class RandomCustomer : MonoBehaviour
{
    public GameObject[] Customers;
    public Orders orders;
    public SeatsManager seats;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        orders = GetComponent<Orders>();
        SpawnRandomCustomer();
        SpawnRandomCustomer();
        SpawnRandomCustomer();
        SpawnRandomCustomer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomCustomer()
    {
        if (seats.SeatsTakenCount >= seats.Seats.Length)
            return;
        int randomCustomer;
        randomCustomer = Random.Range(0, Customers.Length);
        GameObject SpawnedCustomer = Instantiate(Customers[randomCustomer], transform, true);
        Customer customer = SpawnedCustomer.GetComponent<Customer>();
        int orderAmount = GetRandomAmountOfOrders();
        for (int i = 0; i < orderAmount; i++)
        {
            customer.myOrder.Add(orders.GetRandomOrder());
        }
        customer.Seat = seats.GetAvailableSeats();
        customer.BubbleTime = GetRandomBubbleTimer();
    }
    /// <summary>
    /// 0 - 10 in floats
    /// </summary>
    /// <returns></returns>
    float GetRandomBubbleTimer()
    {
        float random = Random.Range(0, 10);
        return random;
    }
    /// <summary>
    /// 15% to 3 order(s)
    /// 35% to 2 order(s)
    /// 50% to 1 order
    /// </summary>
    /// <returns></returns>
    int GetRandomAmountOfOrders()
    {
        int random = Random.Range(0, 100);
        if (random < 50)
            return 1;
        else if (random < 85)
            return 2;
        else return 3;
    }
}
