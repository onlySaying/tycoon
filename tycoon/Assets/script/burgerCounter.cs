using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class burgerCounter : MonoBehaviour
{
    [SerializeField]KioskLoading[] kl;
    int counting = 0;
    [SerializeField] GameObject burgerCountingUI;
    [SerializeField] TextMeshProUGUI bT;
    
    void Start()
    {
        burgerCountingUI = GameObject.Find("burgerscounter");
        bT = burgerCountingUI.GetComponentInChildren<TextMeshProUGUI>();
        
    }

    void Update()
    {
        
    }

    public void getBurgerCount()
    {
        counting +=  kl[0].order();
        kl[0].closeButton();
        if(bT == null)
        {
            Debug.Log("we dont have bt");
            return; 
        }
        bT.text = "total orders Burger : " + counting;
    }
    public void makeBurger()
    {
        counting--;
        if (bT == null)
        {
            Debug.Log("we dont have bt");
            return;
        }
        bT.text = "total orders Burger : " + counting;
    }
}
