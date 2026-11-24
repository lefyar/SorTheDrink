using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BeverageDetailPanel : MonoBehaviour
{
    [Header("Panel")]
    [SerializeField] private GameObject detailPanel;

    [Header("Images")]
    [SerializeField] private Image productImage;
    [SerializeField] private Image nutritionImage;
    [SerializeField] private Image nutritionScoreImage;
    [SerializeField] private Image healthyImpactImage;

    [Header("Texts")]
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text brandText;

    public void ShowDetail(BeverageData data)
    {
        if (data == null) return;

        detailPanel.SetActive(true);

        productImage.sprite = data.productImage;
        nutritionImage.sprite = data.nutritionImage;
        nutritionScoreImage.sprite = data.nutritionScoreImage;
        healthyImpactImage.sprite = data.healthyImpactImage;

        nameText.text = data.displayName;
        brandText.text = data.brand;
    }

    public void CloseDetail()
    {
        detailPanel.SetActive(false);
    }
}