using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInfo : MonoBehaviour
{
    [SerializeField] string foodName;
    FoodManager foodManager;
    Collision2D c2d;
    [SerializeField] ParticleSystem particle;
    private void Awake()
    {
        foodManager = FindObjectOfType<FoodManager>();
    }

    private void Update()
    {
        if(c2d !=null)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                foodManager.putInIngredients(foodName);
                particle.Play();
            }
        }
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
        c2d = null;
    }
    public string getFoodName()
    {
        return foodName;
    }
}
