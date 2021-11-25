using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeButtons : MonoBehaviour
{
    [SerializeField]
    private GameData gameData;
    public void SellSticks()
    {
        gameData.Coins += gameData.Sticks;
        gameData.Sticks = 0;
    }

    public void SellStones()
    {
        gameData.Coins += gameData.Stones * 1.2f;
        gameData.Stones = 0;
    }
}
