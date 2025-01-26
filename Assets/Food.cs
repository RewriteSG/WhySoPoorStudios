using System.Collections.Generic;
using UnityEngine;


public class Food
{
    public int profit = 0;
    public int size = 1;

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

