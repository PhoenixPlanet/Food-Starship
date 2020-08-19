using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum IngredientCategory
{
    water,
    sauce,
    topping
}

public static class IngredientCategoryToString
{
    public static string ToKorean(IngredientCategory category)
    {
        switch (category)
        {
            case IngredientCategory.water:
                return "물";
            case IngredientCategory.sauce:
                return "소스";
            case IngredientCategory.topping:
                return "토핑";
        }
        return "invalid";
    }
}

public class Flavor
{
    public float Red;
    public float Green;
    public float Blue;
}

public interface Ingredient
{
    IngredientCategory IngredientCategory { get; set; }
    Flavor Flavor { get; set; }
}
