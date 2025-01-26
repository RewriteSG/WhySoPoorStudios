using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
public class Orders : MonoBehaviour
{
    /// <summary>
    /// Food Icons
    /// </summary>
    public string[] FoodToOrderIcons;

    public string GetRandomOrder()
    {
        int random = Random.Range(0, FoodToOrderIcons.Length);
        return FoodToOrderIcons[random];
    }

}
