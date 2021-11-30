using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Click : MonoBehaviour
{
    public event Action OnClicked;
    //private int dgLvl;
    private void Start()
    {
    }
    /*
    public int DgLvl
    {
        get { return dgLvl; }
        set { dgLvl = value; }
    }
    */

    private void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            //OnClicked?.Invoke();
            //CoinUI();
            //&& (clickScene.activeInHierarchy)
        }*/
    }
    public void RaiseClickEvent()
    {
        OnClicked?.Invoke();
    }

}
