using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemHandler : MonoBehaviour
{
    public int slotNum { get; private set; }
    public int Amount { get; private set; }
    public ItemInfo itemInfo;
    [SerializeField] private Image itemImage; 

    public void Init(ItemInfo item, int amount)
    {
        itemInfo = item;
        Amount = amount;

        if (itemImage == null)
            itemImage = GetComponent<Image>();

        if (itemImage != null && item.icon != null)
        {
            itemImage.sprite = item.icon;
            itemImage.enabled = true;
        }
    }
}