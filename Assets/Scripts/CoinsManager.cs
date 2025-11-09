using UnityEngine;
using TMPro;

public class CoinsManager : MonoBehaviour
{
    [Header("Coin Settings")]
    public int collectedCoins = 0;

    [Header("UI Reference")]
    public TextMeshProUGUI coinsText;

    void Start()
    {
        UpdateCoinDisplay();
    }

    // Метод для сбора монеты (будет вызываться из монет)
    public void CollectCoin()
    {
        collectedCoins++;
        UpdateCoinDisplay();
    }

    void UpdateCoinDisplay()
    {
        coinsText.text = $"Монеты: {collectedCoins}";
    }
}