using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    [SerializeField]
    private GameData gameData;

    [SerializeField]
    private Text textSticksAmount;
    [SerializeField]
    private Text textStonesAmount;
    [SerializeField]
    private Text textMushroomsAmount;
    [SerializeField]
    private Text textBerriesAmount;
    [SerializeField]
    private Text textCoins;
   

    private void Update()
    {
        AmountValues();
    }
    private void AmountValues()
    {
        int tSticks = (int)gameData.Sticks;
        textSticksAmount.text = tSticks.ToString();
        int tStones = (int)gameData.Stones;
        textStonesAmount.text = tStones.ToString();
        int tMushrooms = (int)gameData.Mushrooms;
        textMushroomsAmount.text = tMushrooms.ToString();
        int tBerries = (int)gameData.Berries;
        textBerriesAmount.text = tBerries.ToString();
        int tCoins = (int)gameData.Coins;
        textCoins.text = tCoins.ToString();
    }
}
