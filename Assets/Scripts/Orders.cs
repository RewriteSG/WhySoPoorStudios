using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
public class Orders : MonoBehaviour
{
    /// <summary>
    /// Food Icons
    /// </summary>
    public Everything Food;

    public Food GetRandomOrder()
    {
        int random = Random.Range(0, Food.Foods.Count);
        return Food.Foods[random];
    }

}
