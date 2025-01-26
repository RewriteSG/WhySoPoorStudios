using UnityEngine;
using UnityEngine.Sprites;
public class RandomCustomer : MonoBehaviour
{
    public GameObject[] Customers;
    public Orders orders;
    public SeatsManager seats;
    public float spawnRate = 3;
    public float spawnTimer = 0;
    public GameObject Door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        orders = GetComponent<Orders>();
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTimer>= spawnRate)
        {
            spawnTimer = 0;
            SpawnRandomCustomer();
        }
        else
        {
            spawnTimer += Time.deltaTime;
        }
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
        customer.transform.position = Door.transform.position;
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
