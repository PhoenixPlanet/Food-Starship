using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[System.Serializable]
class BaseFlavor
{

    [SerializeField, Range(0,10)]
    int sweetness;
    [SerializeField, Range(0, 10)]
    int bitter;
    [SerializeField, Range(0, 10)]
    int salty;
    [SerializeField, Range(0, 10)]
    int umami;
    [SerializeField, Range(0, 10)]
    int sour;
    [SerializeField, Range(0, 10)]
    int spicy;
    [SerializeField, Range(0, 10)]
    int astringent;
    [SerializeField, Range(0, 10)]
    int greasy;
}

public class FlavorObject : ScriptableObject
{
    const string PATH = "Assets/Editor/NewFlavor.asset";

    [SerializeField]
    string ownFlavor;
    [SerializeField]
    FoodTexture texture;
    [SerializeField]
    BaseFlavor baseFlavor;


    [MenuItem("Food/Create Flavor")]
    static void CreateScriptableObject()
    {
        // 부모를 인스턴스화
        var flavor = ScriptableObject.CreateInstance<FlavorObject>();

        // 부모를 Asset으로 저장
        AssetDatabase.CreateAsset(flavor, PATH);

        // Import 해서 최신 상태로 함
        AssetDatabase.ImportAsset(PATH);
    }
}