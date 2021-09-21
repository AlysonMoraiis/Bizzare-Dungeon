using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeButtons : MonoBehaviour
{
    [SerializeField]
    private Text textCoins;
    [SerializeField]
    private CoinsData coinsData;
    public void SellSticks()
    {
        coinsData.Coins += coinsData.Sticks;
        coinsData.Sticks = 0;
        int tCoins = (int)coinsData.Coins;
        textCoins.text = tCoins.ToString();
    }

    public void SellStones()
    {
        coinsData.Coins += coinsData.Stones * 1.2f;
        coinsData.Stones = 0;
        int tCoins = (int)coinsData.Coins;
        textCoins.text = tCoins.ToString();
    }
}
