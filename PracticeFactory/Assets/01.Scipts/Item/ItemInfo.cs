using UnityEngine;
public enum ItemType
{
    None,
    Head,
    Body,
    Hand,
    Back,
    Material,
}

[CreateAssetMenu(fileName = "NewItem", menuName = "New ItemData")]
public class ItemInfo : ScriptableObject
{
    public int itemId;
    public string itemName;
    public string description;
    public int stack;
    public Sprite icon;
    public ItemType itemType;
    public GameObject itemPrefab;
}