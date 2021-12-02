using UnityEngine;
using UnityEngine.UI;

public class ClickAreaButtons : MonoBehaviour
{
    [Header("Stick")]
    [SerializeField]
    private Text textSticksClick;
    [SerializeField]
    private Text textSticksAmount;
    [SerializeField]
    private Text textSticksUpButton;
    [SerializeField]
    private GameObject sticksUpButton;
    private float sticksUpPrice = 5f;
    private float sticksAmount = 1;
    private float stickClickValue;

    [Header("Stone")]
    [SerializeField]
    private Text textStonesClick;
    [SerializeField]
    private Text textStonesAmount;
    [SerializeField]
    private Text textStonesUpButton;
    [SerializeField]
    private GameObject stonesUpButton;
    private float stonesUpPrice = 500f;
    private float stonesAmount;
    private float stonesClickValue;
    
    [Header("Mushroom")]
    [SerializeField]
    private Text textMushroomClick;
    [SerializeField]
    private Text textMushroomAmount;
    [SerializeField]
    private Text textMushroomsUpButton;
    [SerializeField]
    private GameObject mushroomsUpButton;
    private float mushroomsUpPrice = 500f;
    private float mushroomsAmount;
    private float mushroomsClickValue;
    
    [Header("Berry")]
    [SerializeField]
    private Text textBerryClick;
    [SerializeField]
    private Text textBerryAmount;
    [SerializeField]
    private Text textBerriesUpButton;
    [SerializeField]
    private GameObject berriesUpButton;
    private float berriesUpPrice = 1500f;
    private float berriesAmount;
    private float berriesClickValue;

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

        if (stonesUpPrice > gameData.Sticks)
        {
            stonesUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
        else
        {
            stonesUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        }
        
        if (mushroomsUpPrice > gameData.Stones)
        {
            mushroomsUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
        else
        {
            mushroomsUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        }
        
        if (berriesUpPrice > gameData.Berries)
        {
            berriesUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
        else
        {
            berriesUpButton.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        }
    }
    private void UpgradeSound()
    {
        SoundManager.Instance.PlaySound(upgradeSound);
    }
    private void CoinUI()
    {
        SoundManager.Instance.PlaySound(clickSound);
        gameData.Sticks += sticksAmount;
        gameData.Stones += stonesAmount;
        gameData.Mushrooms += mushroomsAmount;
        gameData.Berries += berriesAmount;
    }


    //////////////////// Up Buttons ////////////////////////
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
        if (gameData.Sticks > stonesUpPrice)
        {
            gameData.Sticks -= stonesUpPrice;
            StonesUpgrade();
            UpgradeSound();
        }
    }  
    public void MushroomsUpButton()
    {
        if(gameData.Stones > mushroomsUpPrice)
        {
            gameData.Stones -= mushroomsUpPrice;
            MushroomsUpgrade();
            UpgradeSound();
        }
    }
    public void BerriesUpButton()
    {
        if (gameData.Mushrooms > berriesUpPrice)
        {
            gameData.Mushrooms -= berriesUpPrice;
            BerriesUpgrade();
            UpgradeSound();
        }
    }

    ///////////////////// Upgrade Calculator ///////////////////////
    private void SticksUpgrade()
    {
        stickClickValue += 1.2f;
        sticksAmount = stickClickValue;
        sticksUpPrice *= 1.2f;
        int tClickValue = (int)stickClickValue;
        textSticksClick.text = "Click: " + tClickValue.ToString();
        int tUpPrice = (int)sticksUpPrice;
        textSticksUpButton.text = "Cost: " + tUpPrice.ToString();
    }
    private void StonesUpgrade()
    {
        stonesClickValue += 1.2f;
        stonesAmount = stonesClickValue;
        stonesUpPrice *= 1.4f;
        int tStonesClickValue = (int)stonesClickValue;
        textStonesClick.text = "Click: " + tStonesClickValue.ToString();
        int tStonesUpPrice = (int)stonesUpPrice;
        textStonesUpButton.text = "Cost: " + tStonesUpPrice.ToString();
    }
    private void MushroomsUpgrade()
    {
        mushroomsClickValue += 1.2f;
        mushroomsAmount = mushroomsClickValue;
        mushroomsUpPrice *= 1.6f;
        int tMushroomsClickValue = (int)mushroomsClickValue;
        textMushroomClick.text = "Click: " + tMushroomsClickValue.ToString();
        int tMushroomsUpPrice = (int)mushroomsUpPrice;
        textMushroomsUpButton.text = "Cost: " + tMushroomsUpPrice.ToString();
    }
    private void BerriesUpgrade()
    {
        berriesClickValue += 1.2f;
        berriesAmount = berriesClickValue;
        berriesUpPrice *= 1.8f;
        int tBerriesClickValue = (int)berriesClickValue;
        textBerryClick.text = "Click: " + tBerriesClickValue.ToString();
        int tBerriesUpPrice = (int)berriesUpPrice;
        textBerriesUpButton.text = "Cost: " + tBerriesUpPrice.ToString();
    }

    private void ButtonsValues()
    {
        int tClickValue = (int)stickClickValue;
        textSticksClick.text = "Click: " + tClickValue.ToString();
        int tUpPrice = (int)sticksUpPrice;
        textSticksUpButton.text = "Cost: " + tUpPrice.ToString();

        int tStonesClickValue = (int)stonesClickValue;
        textStonesClick.text = "Click: " + tStonesClickValue.ToString();
        int tStonesUpPrice = (int)stonesUpPrice;
        textStonesUpButton.text = "Cost: " + tStonesUpPrice.ToString();
        
        int tMushroomsClickValue = (int)mushroomsClickValue;
        textMushroomClick.text = "Click: " + tMushroomsClickValue.ToString();
        int tMushroomsUpPrice = (int)mushroomsUpPrice;
        textMushroomsUpButton.text = "Cost: " + tMushroomsUpPrice.ToString();
        
        int tBerriesClickValue = (int)berriesClickValue;
        textBerryClick.text = "Click: " + tBerriesClickValue.ToString();
        int tBerriesUpPrice = (int)berriesUpPrice;
        textBerriesUpButton.text = "Cost: " + tBerriesUpPrice.ToString();
    }
}
