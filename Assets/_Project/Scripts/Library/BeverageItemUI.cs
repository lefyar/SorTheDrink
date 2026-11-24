
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BeverageItemUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private Image productImage;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private Button button;

    private BeverageData beverageData;
    private Action<BeverageData> onSelected;

    public void Setup(
        BeverageData data,
        Action<BeverageData> callback
    )
    {
        beverageData = data;
        onSelected = callback;

        if (productImage != null)
            productImage.sprite = data.productImage;

        if (nameText != null)
            nameText.text = data.displayName;

        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        onSelected?.Invoke(beverageData);
    }
}
