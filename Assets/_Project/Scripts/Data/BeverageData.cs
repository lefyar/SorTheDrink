
using UnityEngine;

public enum BeverageCategory
{
    Soda,
    Tea,
    Juice,
    EnergyDrink,
    Coffee,
    Other
}

[CreateAssetMenu(
    fileName = "BeverageData",
    menuName = "SoTheDrink/Beverage Data"
)]
public class BeverageData : ScriptableObject
{
    [Header("Identity")]
    public string id;
    public string displayName;
    public string brand;
    public string targetName;
    public BeverageCategory category;

    [Header("Product")]
    public int volumeMl;
    public Sprite productImage;

    [Header("Nutrition - Per Whole Bottle/Can")]
    public float energyKcal;
    public float sugarGram;
    public float sodiumMg;

    [Header("Additional Information")]
    [TextArea(2, 5)]
    public string ingredients;


    [Header("AR Assets")]
    public Sprite floatingCardImage;
    public GameObject sugarModelPrefab;


    [TextArea(2, 5)]
    public string description;

    
    [Header("Detail Images")]
    public Sprite nutritionImage;
    public Sprite nutritionScoreImage;
    public Sprite healthyImpactImage;
}
