using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : CoinsCalculator
{
       
    //private int dgLvl;
    void Start()
    {
    }
    /*
    public int DgLvl
    {
        get { return dgLvl; }
        set { dgLvl = value; }
    }
    */

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (battleScene.activeInHierarchy))
        {
            CoinUI();
        }
    }

}
