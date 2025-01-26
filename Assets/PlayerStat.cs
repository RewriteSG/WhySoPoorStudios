using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    [SerializeField]
    private int currency = 0;

    public void AddCurrency(int currencyToAdd) {  currency += currencyToAdd; }

    public void RemoveCurrency(int currencyToRemove) { currency -= currencyToRemove; }

    public int GetCurrency() { return currency; }

    public void Update()
    {
        if(currency < 0) currency = 0;
    }
}
