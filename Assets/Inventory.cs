using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public int coins = 0;
    public Text coinText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        coins++;
        UpdateUI();
    }

    void UpdateUI()
    {
        coinText.text = "Coins: " + coins.ToString();
    }
}
//This code is generated with AI