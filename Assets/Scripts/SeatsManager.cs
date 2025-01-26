using UnityEngine;

using System.Collections;
using System.Collections.Generic;
public class SeatsManager : MonoBehaviour
{
    public static SeatsManager instance;
    public GameObject[] Seats;
    public List<bool> SeatsTaken;
    public int SeatsTakenCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(GameObject seat in Seats)
        {
            SeatsTaken.Add(false);
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject GetAvailableSeats()
    {
        if(SeatsTakenCount < Seats.Length)
        for (int i = 0; i < Seats.Length; i++)
        {
            if(!SeatsTaken[i])
            {
                SeatsTaken[i] = true;
                SeatsTakenCount++;
                return Seats[i];
            }    
        }
        return null;
    }
    public void SetSeatAvailable(GameObject seat)
    {
        for (int i = 0; i < Seats.Length; i++)
        {
            if(seat == Seats[i])
            {
                SeatsTaken[i] = false;
                SeatsTakenCount--;
                
            }
        }
    }

}
