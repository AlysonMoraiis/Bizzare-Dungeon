using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCalculator : MonoBehaviour
{

    private int coins;
    private int coinAmount;

    private int clickValue;

    private int upPrice = 5;

    //texts
    [SerializeField]
    private Text textClick;
    [SerializeField]
    private Text textCoins;
    [SerializeField]
    private Text textUpPrice;
    [SerializeField]
    protected GameObject gameObject;

    void Awake()
    {
        Calculator();
    }

    private void FixedUpdate()
    {
        textCoins.text = coins.ToString();
    }


    protected void CoinUI()
    {
        coins += coinAmount;
        Debug.Log(coinAmount);
    }

    private void UpButton()
    {
        if(coins > upPrice)
        {
            coins -= upPrice;
            Calculator();
        }

    }

    private void Calculator()
    {
        clickValue += 2;
        textClick.text = clickValue.ToString();
        coinAmount = clickValue;
        upPrice *= 2;
        textUpPrice.text = upPrice.ToString();
    }
   
}
