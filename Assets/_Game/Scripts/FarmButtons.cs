using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmButtons : MonoBehaviour
{
    private int carrotLvl = 1;

    [SerializeField]
    private Text textCarrotLvl;
    [SerializeField]
    private GameData gameData;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Carrot()
    {
        carrotLvl += 1;
        textCarrotLvl.text = carrotLvl.ToString();
    }
}
