using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerRecommend : MonoBehaviour
{
    Rigidbody2D rb2d;
    CapsuleCollider2D cc2d;
    BoxCollider2D bc2d;
    GameObject RecommendUI;
    Rigidbody2D rb2dP = null;
    bool activate = false;
    
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        cc2d = GetComponent<CapsuleCollider2D>();
        bc2d = GetComponent<BoxCollider2D>();
        RecommendUI = GameObject.Find("Recommendery");
        
    }

    private void Start()
    {
        RecommendUI.SetActive(false);
        activate = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&activate == true)
        {
            RecommendUI.SetActive(false);
            activate = false;
        }
        else if(rb2d != null && Input.GetKeyDown(KeyCode.Space) && activate == false)
        {
            if(rb2d.gameObject.tag == "Player")
            RecommendUI.SetActive(true);
            activate = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            rb2d = collision.gameObject.GetComponent<Rigidbody2D>() ;
            RecommendUI.SetActive(true);
            activate = true;
        }
       
    }
    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            RecommendUI.SetActive(false);
            rb2d = null;
            activate = false;
        }
    }
}
