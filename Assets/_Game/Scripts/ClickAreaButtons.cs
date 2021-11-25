using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAreaButtons : MonoBehaviour
{
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

    [Header("Others")]
    [SerializeField]
    private Click click;
    [SerializeField]
    private AudioClip clickSound;
    [SerializeField]
    private AudioClip upgradeSound;
    [SerializeField]
    private GameData gameData;
    

    private void Awake()
    {
        ButtonsValues();
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
        if (sticksUpPrice > gameData.Sticks)
        {
            sticksUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
        else
        {
            sticksUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        }

        if (stonesUpPrice > gameData.Coins)
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
        SoundManager.Instance.PlaySound(clickSound);
        gameData.Sticks += sticksAmount;
        gameData.Stones += stonesAmount;
    }
    public void SticksUpButton()
    {
        if(gameData.Sticks > sticksUpPrice)
        {
            gameData.Sticks -= sticksUpPrice;
            SticksUpgrade();
            UpgradeSound();
        }
    }

    public void StonesUpButton()
    {
        if (gameData.Coins > stonesUpPrice)
        {
            gameData.Coins -= stonesUpPrice;
            StonesUpgrade();
            UpgradeSound();
        }
    }

    private void UpgradeSound()
    {
        SoundManager.Instance.PlaySound(upgradeSound);
    }

    private void SticksUpgrade()
    {
        stickClickValue += 1.1f;
        sticksAmount = stickClickValue;
        sticksUpPrice *= 1.4f;
        int tClickValue = (int)stickClickValue;
        textSticksClick.text = "Click: " + tClickValue.ToString();
        int tUpPrice = (int)sticksUpPrice;
        textSticksUpButton.text = "Cost: " + tUpPrice.ToString();
    }
    private void StonesUpgrade()
    {
        stonesClickValue += 1.1f;
        stonesAmount = stonesClickValue;
        stonesUpPrice *= 1.6f;
        int tStonesClickValue = (int)stonesClickValue;
        textStonesClick.text = "Click: " + tStonesClickValue.ToString();
        int tStonesUpPrice = (int)stonesUpPrice;
        textStonesUpButton.text = "Cost: " + tStonesUpPrice.ToString();
    }
    private void ButtonsValues()
    {
        int tStonesClickValue = (int)stonesClickValue;
        textStonesClick.text = "Click: " + tStonesClickValue.ToString();
        int tStonesUpPrice = (int)stonesUpPrice;
        textStonesUpButton.text = "Cost: " + tStonesUpPrice.ToString();

        int tClickValue = (int)stickClickValue;
        textSticksClick.text = "Click: " + tClickValue.ToString();
        int tUpPrice = (int)sticksUpPrice;
        textSticksUpButton.text = "Cost: " + tUpPrice.ToString();
    }
}
