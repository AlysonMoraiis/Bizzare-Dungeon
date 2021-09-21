using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAreaButtons : MonoBehaviour
{

    protected float sticks;
    protected float stones;
    protected float sticksUpPrice = 5f;
    protected float stonesUpPrice = 150f;

    private float sticksAmount = 1;
    private float stickClickValue;

    private float stonesAmount;
    private float stonesClickValue;

    [Header("Stick")]
    [SerializeField]
    private Text textSticksClick;
    [SerializeField]
    private Text textSticksAmount;
    [SerializeField]
    private Text textSticksUpButton;
    [SerializeField]
    private GameObject sticksUpButton;

    [Header("Stone")]
    [SerializeField]
    private Text textStonesClick;
    [SerializeField]
    private Text textStonesAmount;
    [SerializeField]
    private Text textStonesUpButton;
    [SerializeField]
    private GameObject stonesUpButton;

    [SerializeField]
    private Click click;
    





    private void Awake()
    {
        UpgradeText();
    }

    private void OnEnable()
    {
        click.OnClicked += CoinUI;
    }
    private void OnDisable()
    {
        click.OnClicked -= CoinUI;
    }

    private void FixedUpdate()
    {
        UpgradeText();
        if (sticksUpPrice > sticks)
        {
            sticksUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
        else
        {
            sticksUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        }

        if (stonesUpPrice > sticks)
        {
            stonesUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
        else
        {
            stonesUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        }
    }
    protected void CoinUI()
    {
        sticks += sticksAmount;
        stones += stonesAmount;
    }
    public void SticksUpButton()
    {
        if(sticks > sticksUpPrice)
        {
            sticks -= sticksUpPrice;
            SticksUpgrade();
        }
    }

    public void StonesUpButton()
    {
        if (sticks > stonesUpPrice)
        {
            sticks -= stonesUpPrice;
            StonesUpgrade();
        }
    }

    private void SticksUpgrade()
    {
        stickClickValue += 1.1f;
        sticksAmount = stickClickValue;
        sticksUpPrice *= 1.4f;
        int tClickValue = (int)stickClickValue;
        textSticksClick.text = "CLICK:" + tClickValue.ToString();
        int tUpPrice = (int)sticksUpPrice;
        textSticksUpButton.text = "COST:" + tUpPrice.ToString();
    }
    private void StonesUpgrade()
    {
        stonesClickValue += 1.1f;
        stonesAmount = stonesClickValue;
        stonesUpPrice *= 1.6f;
        int tStonesClickValue = (int)stonesClickValue;
        textStonesClick.text = "CLICK:" + tStonesClickValue.ToString();
        int tStonesUpPrice = (int)stonesUpPrice;
        textStonesUpButton.text = "COST:" + tStonesUpPrice.ToString();
    }

    protected void UpgradeText()
    {
        //Top Prices
        int tSticks = (int)sticks;
        textSticksAmount.text = tSticks.ToString();
        int tStones = (int)stones;
        textStonesAmount.text = tStones.ToString();

        //Button Prices
        int tStonesClickValue = (int)stonesClickValue;
        textStonesClick.text = "CLICK:" + tStonesClickValue.ToString();
        int tStonesUpPrice = (int)stonesUpPrice;
        textStonesUpButton.text = "COST:" + tStonesUpPrice.ToString();

        int tClickValue = (int)stickClickValue;
        textSticksClick.text = "CLICK:" + tClickValue.ToString();
        int tUpPrice = (int)sticksUpPrice;
        textSticksUpButton.text = "COST:" + tUpPrice.ToString();
    }
}
