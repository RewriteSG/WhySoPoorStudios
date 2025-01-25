using System.Collections.Generic;
using UnityEngine;

public class Everything : MonoBehaviour
{
    public List<Ingredient> PlayerChoice = new List<Ingredient> { };


    Food BubbleTea = new Food();

    void Start()
    {
        BubbleTea.Recipe = new List<Food.INGREDIENTS> {
            Food.INGREDIENTS.Ice,
            Food.INGREDIENTS.Ice,
            Food.INGREDIENTS.Ice
        };


        for (int i = 0; i < 3; i++)
        {
            Debug.Log(BubbleTea.Recipe[i]);
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
            Debug.Log(BubbleTea.Recipe[0]);

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
                    if (PlayerChoice[i].id != (int)(BubbleTea.Recipe[i]))
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
