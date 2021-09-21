using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeButtons : MonoBehaviour
{
    [SerializeField]
    private CoinsData coinsData;
    public void SellSticks()
    {
        coinsData.Coins += coinsData.Sticks;
        coinsData.Sticks = 0;
    }

    public void SellStones()
    {
        coinsData.Coins += coinsData.Stones * 1.2f;
        coinsData.Stones = 0;
    }
}
