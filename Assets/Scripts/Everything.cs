using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Everything : MonoBehaviour
{
    public Food PlayerChoice = new Food { };

    public Food inBlender = new Food { };
    [SerializeField]bool IsDrinkReady = false;
    public float BlenderCookTime = 4;

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
    IEnumerator CookDrink(float time)
    {
        // help me codemaid
        yield return new WaitForSeconds(time);
        IsDrinkReady = true;
    }
    bool Blender()
    {
        PlayerChoice.Recipe.Add(Food.INGREDIENTS.Blender);
        for (int i = 0; i < Foods.Count; i++)
        {
            bool checkifcorrectorder = true;
            if (PlayerChoice.Recipe.Count == Foods[i].Recipe.Count)
            {
                for (int j = 0; j < PlayerChoice.Recipe.Count; j++)
                {
                    if (PlayerChoice.Recipe[j] != (Foods[i].Recipe[j]))
                    {
                        checkifcorrectorder = false;
                        break;
                    }
                }
                if (checkifcorrectorder)
                {

                    inBlender.Recipe = PlayerChoice.Recipe;
                    PlayerChoice.Recipe.Clear();
                    return true;
                }
            }
        }
        for (int i = 0; i < PlayerChoice.Recipe.Count; i++)
        {
            inBlender.Recipe.Add(PlayerChoice.Recipe[i]);
        }
        PlayerChoice.Recipe.Clear();
        return false;
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

        if (Input.GetKeyDown(KeyCode.F) && inBlender.Recipe.Count <= 0 && !IsDrinkReady)
        {
            StartCoroutine(CookDrink(BlenderCookTime));
            if (!Blender())
            {
                // Mysterious Drink
                Debug.Log("wrong");
            }
        }
        if(Input.GetKeyDown(KeyCode.F) && inBlender.Recipe.Count > 0 && IsDrinkReady && PlayerChoice.Recipe.Count>0)
        {
            StartCoroutine(CookDrink(BlenderCookTime));
            List<Food.INGREDIENTS> temp = new List<Food.INGREDIENTS>();
            for (int i = 0; i < inBlender.Recipe.Count; i++)
            {
                temp.Add(inBlender.Recipe[i]);
            }
            inBlender.Recipe.Clear(); 
            if (!Blender())
            {
                Debug.Log("Wrong");
            }
            for (int i = 0; i < temp.Count; i++)
            {
                PlayerChoice.Recipe.Add(temp[i]);
            }
            IsDrinkReady = false;
        }
        if(Input.GetKeyDown(KeyCode.F) && inBlender.Recipe.Count > 0 && IsDrinkReady && PlayerChoice.Recipe.Count <= 0)
        {
            
            for (int i = 0; i < inBlender.Recipe.Count; i++)
            {
                PlayerChoice.Recipe.Add(inBlender.Recipe[i]);
            }
            inBlender.Recipe.Clear();
            IsDrinkReady = false;

        }


        // This is to clear the recipe:
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B pressed");
            PlayerChoice.Recipe.Clear();
        }
    }
}