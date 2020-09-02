using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class SauceBehaviourScript : MonoBehaviour
{
    Sauce sauce;
    public Dish dish;
    // Start is called before the first frame update
    void Awake()
    {
        Flavor flavor = new Flavor
        {
            Red = gameObject.GetComponent<Image>().color.r,
            Green = gameObject.GetComponent<Image>().color.g,
            Blue = gameObject.GetComponent<Image>().color.b
    };
        sauce = new Sauce(flavor);
        Debug.Log(sauce.Flavor);
    }

    public void onClick()
    {
        if (GameManager.gameState == GameState.start)
        {
            dish.AddSauce(this.sauce);
        }
    }

   
}
