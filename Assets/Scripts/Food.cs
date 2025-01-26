using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Food
{
    public string Name;
    public int profit = 0;

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

