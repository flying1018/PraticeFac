using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemHandler : MonoBehaviour
{
    public int slotNum { get; private set; }
    public int Amount { get; private set; }
    public ItemInfo itemInfo;
}