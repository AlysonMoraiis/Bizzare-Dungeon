using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCalculator : MonoBehaviour
{

    protected int coins;
    private int coinAmount;

    private int clickValue;

    protected int upPrice = 5;

    //texts
    [SerializeField]
    private Text textClick;
    [SerializeField]
    private Text textCoins;
    [SerializeField]
    private Text textUpPrice;
    [SerializeField]
    protected GameObject battleScene;

    public GameObject upButton;

    void Awake()
    {
        Calculator();
    }

    private void FixedUpdate()
    {
        textCoins.text = coins.ToString();
        if (upPrice > coins)
        {
            upButton.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
        else
        {
            upButton.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        }
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
        textClick.text = "CLICK:" + clickValue.ToString();
        coinAmount = clickValue;
        upPrice *= 2;
        textUpPrice.text = "COST:" + upPrice.ToString();
    }
   
}
