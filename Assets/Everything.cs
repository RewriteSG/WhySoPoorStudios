using System.Collections.Generic;
using UnityEngine;

public class Everything : MonoBehaviour
{
    public List<Ingredient> PlayerChoice = new List<Ingredient> { };


    Food OceanLatte = new Food();
    Food BubbleSplash = new Food();
    Food SSCooler = new Food();
    Food ChocoCake = new Food();
    Food BubbleCake = new Food();
    Food StrawberryCake = new Food();




    void Start()
    {
        OceanLatte.Recipe = new List<Food.INGREDIENTS> {
            Food.INGREDIENTS.Cup,
            Food.INGREDIENTS.Milk,
            Food.INGREDIENTS.Syrup,
            Food.INGREDIENTS.Blender,
            Food.INGREDIENTS.Foam,
        };

        BubbleSplash.Recipe = new List<Food.INGREDIENTS> {
            Food.INGREDIENTS.Cup,
            Food.INGREDIENTS.Bubbles,
            Food.INGREDIENTS.Seaweed,
            Food.INGREDIENTS.Salt
        };

        SSCooler.Recipe = new List<Food.INGREDIENTS> {
            Food.INGREDIENTS.Cup,
            Food.INGREDIENTS.Syrup,
            Food.INGREDIENTS.Salt,
            Food.INGREDIENTS.Milk,
            Food.INGREDIENTS.Blender
        };



        for (int i = 0; i < 3; i++)
        {
            Debug.Log(OceanLatte.Recipe[i]);
        }

        for (int i = 0; i < PlayerChoice.Count; i++)
        {
            Debug.Log(PlayerChoice[i]);
        }

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            PlayerChoice.Add(new Ingredient(0));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(OceanLatte.Recipe[0]);

            for (int i = 0; i < PlayerChoice.Count; i++)
            {
                Debug.Log(PlayerChoice[i].id);
            }
        }



        if(Input.GetKeyDown(KeyCode.B))
        {
            if (PlayerChoice.Count != BubbleTea.Recipe.Count)
            {
                Debug.Log("wrong order fucker");
            }
            else {
                bool checkifcorrectorder = true;
                for (int i = 0; i < PlayerChoice.Count; i++)
                {
                    if (PlayerChoice[i].id != (int)(OceanLatte.Recipe[i]))
                    {
                        checkifcorrectorder = false;
                        break;
                    }
                }
                if (!checkifcorrectorder)
                {
                    Debug.Log("wronnnnnggg");
                }
                else
                {
                    Debug.Log("nice!!!");
                }
            }
        }
    }
}
