using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : CoinsCalculator
{
    [SerializeField]
    private GameObject upButton;
    // Start is called before the first frame update
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
