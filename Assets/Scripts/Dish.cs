using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class Dish : MonoBehaviour
{
    Sauce sauce;
    Topping topping;
    int portions;
    // Start is called before the first frame update
    void Awake()
    {
        sauce = new Sauce();
        topping = new Topping();
        portions = 0;
        sauce.Flavor.Red = gameObject.GetComponent<Image>().color.r;
        sauce.Flavor.Blue = gameObject.GetComponent<Image>().color.g;
        sauce.Flavor.Green = gameObject.GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        Color color = new Color
        {
            a = 1,
            r = sauce.Flavor.Red,
            g = sauce.Flavor.Green,
            b = sauce.Flavor.Blue
        };
       // Debug.Log(color);
        gameObject.GetComponent<Image>().color = color;
    }

    public void SetDish(Sauce newsauce, Topping newtopping)
    {
        topping = newtopping;
        sauce = newsauce;
    }

    public void AddSauce(Sauce newSauce)
    {
        Debug.Log("add sauce");
        sauce.CombineSauce(newSauce);
        portions += newSauce.Portions;
        Debug.Log(sauce.Flavor);
    }
    public void AddTopping(Topping newTopping)
    {
        portions -= topping.Portions;
        topping = new Topping(newTopping);
        portions += newTopping.Portions;
    }

    public Topping GetTopping()
    {
        return topping;
    }

    public Sauce GetSauce()
    {
        return sauce;
    }

    public void Reset()
    {
        sauce.Flavor.Red = 1f;
        sauce.Flavor.Green = 1f;
        sauce.Flavor.Blue = 1f;
        topping.ToppingSprite = null;
    }
}
