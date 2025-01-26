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
        Cup = 0,
        Bubbles,
        Seaweed,
        Salt,
        Milk,
        Foam,
        Syrup,
        Blender,
        Plate,
        BubbleCake,
        ChocoCake,
        StrawberryCake
    }

    public Food()
    {
    }
}

