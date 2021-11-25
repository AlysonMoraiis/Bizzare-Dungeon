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
    private Text textCoins;

    private void Update()
    {
        TopValues();
    }
    private void TopValues()
    {
        int tSticks = (int)gameData.Sticks;
        textSticksAmount.text = tSticks.ToString();
        int tStones = (int)gameData.Stones;
        textStonesAmount.text = tStones.ToString();
        int tCoins = (int)gameData.Coins;
        textCoins.text = tCoins.ToString();
    }
}
