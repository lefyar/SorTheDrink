
using UnityEngine;
using UnityEngine.UI;

public class ARContentView : MonoBehaviour
{
    [Header("Beverage Data")]
    [SerializeField] private BeverageData beverageData;

    [Header("UI")]
    [SerializeField] private Image cardImage;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        if (beverageData == null)
        {
            Debug.LogError("BeverageData is missing!", this);
            return;
        }

        if (cardImage != null)
        {
            cardImage.sprite = beverageData.floatingCardImage;
            cardImage.preserveAspect = true;
        }
    }
}
