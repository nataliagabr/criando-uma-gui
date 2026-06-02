using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    private int totalCoins;

    private void OnEnable()
    {
        PlayerOM.OnCoinCollected += UpdateCoins;
    }

    private void OnDisable()
    {
        PlayerOM.OnCoinCollected -= UpdateCoins;
    }

    private void UpdateCoins(int amount)
    {
        totalCoins += amount;

        coinText.text = "Moedas: " + totalCoins;
    }
}
