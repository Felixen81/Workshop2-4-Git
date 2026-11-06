using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public int totalCoins;
    public TMP_Text cointext;

    public void ChangeCoins(int amount)
    {
        totalCoins += amount;
        cointext.text = "Coins:" + totalCoins;
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cointext.text = "Coins:" + totalCoins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
