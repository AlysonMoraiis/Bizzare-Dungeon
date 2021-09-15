using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : CoinsCalculator
{
    // Start is called before the first frame update

    private CoinsCalculator cC;
       
    //private int dgLvl;
    void Start()
    {
        cC.GetComponent<CoinsCalculator>();
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
        if (Input.GetKeyDown(KeyCode.Z) && (battleScene.activeInHierarchy))
        {
            CoinUI();
        }
    }

}
