using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : CoinsCalculator
{
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (upPrice > coins)
        {
            GetComponent<UnityEngine.UI.Image>().color = Color.red;
            while (upPrice > coins)
            {
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
