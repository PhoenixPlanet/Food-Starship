using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToppingBehaviourScript : MonoBehaviour
{
    Topping topping;
    public Dish dish;
    public bool enable = true;
    // Start is called before the first frame update
    void Awake()
    {
        topping = new Topping();
        topping.ToppingSprite = gameObject.GetComponent<Image>().sprite;
        topping.Name = gameObject.name;
        gameObject.GetComponent<Button>().enabled = enable;
    }

    // Update is called once per frame
    void Update()
    {
        if (!enable)
        {
            topping = dish.GetTopping();
        }
        gameObject.GetComponent<Image>().sprite = topping.ToppingSprite;
    }

    public void OnClick()
    {
        if (GameManager.gameState == GameState.start)
        {
            dish.AddTopping(this.topping);
        }
    }

    public string GetName()
    {
        return topping.Name;
    }

    public Topping GetTopping()
    {
        return topping;
    }
}
