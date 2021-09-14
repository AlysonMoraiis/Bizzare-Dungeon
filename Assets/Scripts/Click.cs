using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : CoinsCalculator
{
    // Start is called before the first frame update


    private int dgLvl;
    void Start()
    {
        
    }
    public int DgLvl
    {
        get { return dgLvl; }
        set { dgLvl = value; }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && (gameObject.active == true))
        {
            CoinUI();
        }
    }

}
