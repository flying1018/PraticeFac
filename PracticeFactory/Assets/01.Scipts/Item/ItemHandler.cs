using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemHandler : MonoBehaviour
{
    public int slotNum { get; private set; }
    public int Amount { get; private set; }
    public ItemInfo itemInfo;
    public void Init(ItemInfo info, int amount)
    {
        itemInfo = info;
        Amount = amount;
        GetComponent<Image>().sprite = info.icon;
    }
}