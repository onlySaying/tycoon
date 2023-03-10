using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerTable : MonoBehaviour
{
    [SerializeField] GameObject makerUI;
    bool activate = false;
    Collision2D c2d;
    void Start()
    {
        makerUI = GameObject.Find("BurgerMaker");
        makerUI.SetActive(false);
    }
    void Update()
    {
        if(c2d != null && !activate)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                makerUI.SetActive(true);
                activate = true;
            }    
        }
        else if(activate)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                makerUI.SetActive(false);
                activate = false;
            }
        }
    }

    public void closeBtt()
    {
        makerUI.SetActive(false);
        activate = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            c2d = collision;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            c2d = null;
            makerUI.SetActive(false);
            activate = false;
        }
    }
}
