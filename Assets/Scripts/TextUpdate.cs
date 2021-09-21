using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    [SerializeField]
    private CoinsData coinsData;

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
        int tSticks = (int)coinsData.Sticks;
        textSticksAmount.text = tSticks.ToString();
        int tStones = (int)coinsData.Stones;
        textStonesAmount.text = tStones.ToString();
        int tCoins = (int)coinsData.Coins;
        textCoins.text = tCoins.ToString();
    }
}
