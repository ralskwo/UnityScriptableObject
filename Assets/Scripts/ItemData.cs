using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public int itemID;
    public Sprite itemIcon;
}
