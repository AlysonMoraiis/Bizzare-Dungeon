using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeMarketButtons : MonoBehaviour
{
    [SerializeField]
    private GameData gameData;
    public void SellAllSticks()
    {
        gameData.Coins += gameData.Sticks;
        gameData.Sticks = 0;
    }

    public void SellAllStones()
    {
        gameData.Coins += gameData.Stones * 1.5f;
        gameData.Stones = 0;
    }
    
    public void SellAllMushrooms()
    {
        gameData.Coins += gameData.Mushrooms * 2f;
        gameData.Mushrooms = 0;
    }
}
