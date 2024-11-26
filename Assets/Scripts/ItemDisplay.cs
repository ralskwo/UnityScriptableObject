using UnityEngine;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public ItemData itemData;
    public TextMeshProUGUI itemNameText;

    void Start()
    {
        itemNameText.text = itemData.itemName;
    }
}