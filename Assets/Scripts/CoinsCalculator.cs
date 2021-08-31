using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCalculator : MonoBehaviour
{

    public int coins;
    public int coinAmount;

    public int clickValue;

    public int upPrice = 5;

    //texts
    public Text textClick;
    public Text textCoins;
    public Text textUpPrice;

    void Awake()
    {
        Calculator();
    }


    public void CoinUI()
    {
        coins += coinAmount;
        textCoins.text = coins.ToString();
        Debug.Log(coinAmount);
    }

    /*
    public void CoinsMultipliers()
    {
        int coinValue = 7;
    }
    */
    public void UpButton()
    {
        if(coins > upPrice)
        {
            coins -= upPrice;
            Calculator();
        }

    }

    public void Calculator()
    {
        clickValue += 2;
        textClick.text = clickValue.ToString();
        coinAmount = clickValue;
        upPrice *= 2;
        textUpPrice.text = upPrice.ToString();
    }
   
}
