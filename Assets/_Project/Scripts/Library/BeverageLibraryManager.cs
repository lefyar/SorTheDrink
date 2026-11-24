
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeverageLibraryManager : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private BeverageCatalog catalog;

    [Header("UI References")]
    [SerializeField] private Transform contentParent;
    [SerializeField] private BeverageItemUI itemPrefab;
    [SerializeField] private TMP_InputField searchInput;
    [SerializeField] private TMP_Text resultText;
    [SerializeField] private BeverageDetailPanel detailPanel;

    private string currentSearch = "";
    private string currentCategory = "All";

    private readonly List<BeverageItemUI> spawnedItems = new();

    private void Start()
    {
        if (searchInput != null)
            searchInput.onValueChanged.AddListener(OnSearchChanged);

        DisplayBeverages();
    }

    private void OnDestroy()
    {
        if (searchInput != null)
            searchInput.onValueChanged.RemoveListener(OnSearchChanged);
    }

    // Search
    private void OnSearchChanged(string value)
    {
        currentSearch = value.Trim();
        DisplayBeverages();
    }

    // Category filter
    public void FilterByCategory(string category)
    {
        currentCategory = category;
        DisplayBeverages();
    }

    // Display beverage cards
    public void DisplayBeverages()
    {
        ClearBeverages();

        if (catalog == null || contentParent == null || itemPrefab == null)
        {
            Debug.LogError("Library references are missing!");
            return;
        }

        int resultCount = 0;

        foreach (BeverageData beverage in catalog.beverages)
        {
            if (beverage == null)
                continue;

            if (!MatchesSearch(beverage))
                continue;

            if (!MatchesCategory(beverage))
                continue;

            BeverageItemUI item = Instantiate(
                itemPrefab,
                contentParent
            );

            item.Setup(beverage, OnBeverageSelected);
            spawnedItems.Add(item);

            resultCount++;
        }

        if (resultText != null)
            resultText.text = resultCount + " beverages found";
    }

    // Check search keyword
    private bool MatchesSearch(BeverageData beverage)
    {
        if (string.IsNullOrWhiteSpace(currentSearch))
            return true;

        bool matchesName =
            !string.IsNullOrEmpty(beverage.displayName) &&
            beverage.displayName.IndexOf(
                currentSearch,
                StringComparison.OrdinalIgnoreCase
            ) >= 0;

        bool matchesBrand =
            !string.IsNullOrEmpty(beverage.brand) &&
            beverage.brand.IndexOf(
                currentSearch,
                StringComparison.OrdinalIgnoreCase
            ) >= 0;

        return matchesName || matchesBrand;
    }

    // Check selected category
    private bool MatchesCategory(BeverageData beverage)
    {
        if (currentCategory == "All")
            return true;

        return beverage.category.ToString() == currentCategory;
    }

    // Clear old cards
    private void ClearBeverages()
    {
        foreach (BeverageItemUI item in spawnedItems)
        {
            if (item != null)
                Destroy(item.gameObject);
        }

        spawnedItems.Clear();
    }

    // Called when a beverage card is clicked
    private void OnBeverageSelected(BeverageData data)
    {
        Debug.Log("Selected beverage: " + data.displayName);

        if (detailPanel != null)
        {
            detailPanel.ShowDetail(data);
        }
    }

    // Detail panel will be connected later.

}
