using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FoodManager : MonoBehaviour
{
    Dictionary<string, int> burgersIngredient = new Dictionary<string, int>();
    Stack<string> topping = new Stack<string>();
    burgerCounter bc;
    BurgerTable bt;
    [SerializeField] float closeTerm = 0.2f;
    private void Awake()
    {
        bc = FindObjectOfType<burgerCounter>();
        bt = FindObjectOfType<BurgerTable>();
    }
    public void putInIngredients(string foodsName)
    {
        int cnt;
        if (!burgersIngredient.TryGetValue(foodsName, out cnt))
        {
            burgersIngredient.Add(foodsName, 1);
        }
        else
        {
            burgersIngredient[foodsName] = cnt + 1;
            Debug.Log(foodsName + " " + burgersIngredient[foodsName]);
        }
    }

    public void breadButton()
    {
        pushToppings("bread");
        Debug.Log("push");
    }

    public void lettuceButton()
    {
        pushToppings("lettuce");
    }
    public void tomatoButton()
    {
        pushToppings("tomato");
    }
    public void meatButton()
    {
        pushToppings("meat");
    }

    public void pushToppings(string foodsName)
    {
        int cnt;
        Debug.Log(foodsName + " out");
        if (burgersIngredient.TryGetValue(foodsName, out cnt))
        {
            if (cnt >= 1)
            {
                
                burgersIngredient[foodsName] = cnt - 1;
                topping.Push(foodsName);
                Debug.Log(foodsName + " in");
            }
        }
    }

    public void confirmButton()
    {
        checkBurger();
        StartCoroutine("closeButton");
    }

    IEnumerator closeButton()
    {
        yield return new WaitForSecondsRealtime(closeTerm);
        bt.closeBtt();
    }

    public bool cofirmBurger()
    {
        Debug.Log("check");
        if(topping == null)
        {
            return false;
        }
        int max = topping.Count;
        if (max != 5)
        {
            topping.Clear();
            return false;
        };
        for (int i = 0; i < 5; i++)
        {
            if (!checkTopping(i, topping.Pop()))
            {
                topping.Clear();
                return false;
            }
        }
        topping.Clear();
        return true;
    }
    public void checkBurger()
    {
        if (cofirmBurger())
        {
            bc.makeBurger();
        }
        else
        {
            Debug.Log("not receip");
        }
    }
    
    public bool checkTopping(int i, string ingredient)
    {
        if(i == 0)
        {
            if(ingredient == "bread")
            {return true;}
            else
            {return false;}
        }
        else if (i == 1)
        {
            if (ingredient == "lettuce")
            {return true;}
            else
            {return false;}
        }
        else if (i == 2)
        {
            if (ingredient == "tomato")
            {return true;}
            else
            {return false;}
        }
        else if (i == 3)
        {
            if (ingredient == "meat")
            { return true;}
            else {return false;}
        }
        else if(i == 4)
        {
            if (ingredient == "bread")
            { return true; }
            else
            { return false; }
        }



        return false;
    }
}
