using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState
{
    ready,
    start,
    end
}
public class GameManager : MonoBehaviour
{
    public Text txt_state;
    public Dish order, dish;
    public ToppingBehaviourScript[] toppings;
    public static GameState gameState;
    private float accuracy = 0.00f;
    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.ready;
        MakeRandomDish(order);
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameState.ready:
                txt_state.text = "Ready?";
                break;
            case GameState.start:
                txt_state.text = "Go!";
                break;
            case GameState.end:
                txt_state.text = accuracy.ToString("F2") + "%";
                break;
        }
    }
    public void ButtonOnClick(Text text)
    {
        if(gameState == GameState.ready)
        {
            gameState = GameState.start;
            text.text = "Done!";
        }
        else if (gameState == GameState.start)
        {
            gameState = GameState.end;
            CalculateAccuracy();
            text.text = "Re";
        }
        else if (gameState == GameState.end)
        {
            gameState = GameState.ready;
            Reset();
            text.text = "Start";
        }
    }

    void MakeRandomDish(Dish dish)
    {
        Flavor flavor = new Flavor
        {
            Red = Random.Range(0.00f, 1.00f),
            Green = Random.Range(0.00f, 1.00f),
            Blue = Random.Range(0.00f, 1.00f)
        };
        Debug.Log(flavor.Red + "/" + flavor.Green + "/" + flavor.Blue);
        Sauce sause = new Sauce(flavor);
        Topping topping = toppings[Random.Range(0, toppings.Length)].GetTopping();
        dish.SetDish(sause, topping);
    }

    float CalculateAccuracy()
    {
        if(string.Equals(order.GetTopping().Name, dish.GetTopping().Name))
        {
            accuracy += 20;
        }
        accuracy += (1 - (Mathf.Abs(order.GetSauce().Flavor.Red - dish.GetSauce().Flavor.Red)
            + Mathf.Abs(order.GetSauce().Flavor.Green - dish.GetSauce().Flavor.Green)
            + Mathf.Abs(order.GetSauce().Flavor.Blue - dish.GetSauce().Flavor.Blue)) / 3) * 80;
        return accuracy;
    }
    private void Reset()
    {
        dish.Reset();
        MakeRandomDish(order);
    }
}
