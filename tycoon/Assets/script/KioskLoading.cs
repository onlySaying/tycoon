using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KioskLoading : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    BoxCollider2D bc2d;
    [SerializeField]GameObject KioskUI;
    bool activate = false;
    Rigidbody2D rb2d;
    int contentsNum;
    void Start()
    {
        bc2d = GetComponent<BoxCollider2D>();
        if(KioskUI != null)
        {
            KioskUI.SetActive(false);
        }
        activate = false;
        contentsNum = int.Parse(input.text); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rb2d = collision.gameObject.GetComponent<Rigidbody2D>();
            KioskUI.SetActive(true);
            activate = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && activate == true)
        {
            KioskUI.SetActive(false);
            activate = false;
            resetTxt();
        }
        else if (rb2d != null && Input.GetKeyDown(KeyCode.Space) && activate == false)
        {
            if (rb2d.gameObject.tag == "Player")
            {
                KioskUI.SetActive(true);
                activate = true;

            }
        }
    }

    void resetTxt()
    {
        input.text = "0";
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb2d = null;
            activate = false;
            resetTxt();
            KioskUI.SetActive(false);
        }
    }

   public void UpButtonClick()
   {
        contentsNum = order();
        contentsNum++;
        input.text = contentsNum.ToString();
   }
    public void DownButtonClick()
    {
        contentsNum = order();
        if (contentsNum <= 0)
        {
            return;
        }
        contentsNum--;
        input.text = contentsNum.ToString();
    }

    public int order()
    {
        bool isNumeric = int.TryParse(input.text, out contentsNum);
        if (isNumeric)
        {
            return contentsNum;
        }
        contentsNum = 0;
        input.text = "0";
        return contentsNum;
        
    }
    
    public void closeButton()
    {
        resetTxt();
        KioskUI.SetActive(false);
    }
}
