using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sauce :Ingredient
{
    private IngredientCategory ingredientCategory = IngredientCategory.sauce;
    private Flavor flavor = new Flavor();
    private int portions;

    public Sauce()
    {
        flavor.Red = 1f;
        flavor.Green = 1f;
        flavor.Blue = 1f;
        portions = 1;
    }
    public Sauce(Flavor flavor)
    {
        this.flavor.Red = flavor.Red;
        this.flavor.Green = flavor.Green;
        this.flavor.Blue = flavor.Blue;
        portions = 1;
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
    public Flavor Flavor {
        get
        {
            return flavor;
        }
        set
        {
            flavor = value;
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

    public void CombineSauce(Sauce newSauce)
    {
        Sauce sauce = CombineSauce(this, newSauce);
        this.Flavor = sauce.Flavor;
        this.Portions = sauce.Portions;
    }
    public Sauce CombineSauce(Sauce firstSauce, Sauce secondSauce)
    {
        Sauce sauce = new Sauce();
        sauce.Portions = firstSauce.Portions + secondSauce.Portions;
        
        sauce.Flavor.Red = (firstSauce.Flavor.Red * firstSauce.Portions + secondSauce.Flavor.Red * secondSauce.Portions) / sauce.Portions;
        sauce.Flavor.Green = (firstSauce.Flavor.Green * firstSauce.Portions + secondSauce.Flavor.Green * secondSauce.Portions) / sauce.Portions;
        sauce.Flavor.Blue = (firstSauce.Flavor.Blue * firstSauce.Portions + secondSauce.Flavor.Blue * secondSauce.Portions) / sauce.Portions;
        return sauce;
    }
}
