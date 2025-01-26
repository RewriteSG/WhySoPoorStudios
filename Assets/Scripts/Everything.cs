using System.Collections.Generic;
using UnityEngine;

public class Everything : MonoBehaviour
{
    public Food PlayerChoice = new Food { };
    public static Everything Instance;

    public List<Food> Foods = new List<Food>();

    void Start()
    {
        Instance = this;
    }

    bool CheckOrder(Food food)
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

    // Update is called once per frame
    void Update()
    {
        // Press Q to add the entire recipe in:
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            Debug.Log(Foods[0].Recipe[0]);

            for (int i = 0; i < Foods[0].Recipe.Count; i++)
            {
                PlayerChoice.Recipe.Add(Foods[0].Recipe[i]);
            }

            if (CheckOrder(Foods[0]))
            {
                Debug.Log("nigga");
            }
        }

        // This is to clear the recipe:
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B pressed");
            PlayerChoice.Recipe.Clear();
        }
    }
}
