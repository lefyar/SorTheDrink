
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "BeverageCatalog",
    menuName = "SoTheDrink/Beverage Catalog"
)]
public class BeverageCatalog : ScriptableObject
{
    public List<BeverageData> beverages = new();
}
