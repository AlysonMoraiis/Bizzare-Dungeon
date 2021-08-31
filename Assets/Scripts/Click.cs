using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : CoinsCalculator
{
    // Start is called before the first frame update

    int coinValue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            CoinUI();
        }
    }

}
