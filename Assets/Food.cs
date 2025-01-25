using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        food BubbleTea = new food();
        BubbleTea.Recipe = new List<food.INGREDIENTS> {
            food.INGREDIENTS.Ice,
            food.INGREDIENTS.Tea,
            food.INGREDIENTS.Boba,
        };


        for (int i = 0; i < 3; i++)
        {
            Debug.Log(BubbleTea.Recipe[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}



public class food
{
    public int profit = 0;
    public int size = 1;

    public List<INGREDIENTS> Recipe;

    public enum INGREDIENTS
    {
        Ice = 0,
        Tea,
        Boba,
        Water
    }

    public food()
    {
    }
}

