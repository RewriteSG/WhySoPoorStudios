using System.Collections.Generic;
using UnityEngine;


public class Food
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

    public Food()
    {
    }
}

