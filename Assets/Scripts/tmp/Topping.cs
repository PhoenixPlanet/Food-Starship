using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topping : Ingredient
{
    private IngredientCategory ingredientCategory = IngredientCategory.topping;
    private Flavor flavor = new Flavor();
    private int portions;
    private string name = "empty";
    Sprite toppingSprite;


    public Topping()
    {
        flavor.Red = 1f;
        flavor.Green = 1f;
        flavor.Blue = 1f;
        portions = 0;
    }
    public Topping(Topping topping)
    {
        name = topping.name;
        flavor = topping.Flavor;
        ToppingSprite = topping.ToppingSprite;
        portions = topping.portions;
    }
    public IngredientCategory IngredientCategory
    {
        get
        {
            return ingredientCategory;
        }
        set
        {
            ingredientCategory = value;
        }
    }
    public Flavor Flavor
    {
        get
        {
            return flavor;
        }
        set
        {
            flavor = value;
        }
    }
    public Sprite ToppingSprite
    {
        get
        {
            return toppingSprite;
        }
        set
        {
            toppingSprite = value;
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Portions
    {
        get
        {
            return portions;
        }
        set
        {
            portions = value;
        }
    }

}
