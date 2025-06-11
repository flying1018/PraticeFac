using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public InventorySlot inventorySlot;

    public bool AddItem(int itemId, int amount = 1)
    {
        ItemInfo item = ItemDB.GetItemInfo(itemId);
        if (item == null)
        {
            DebugHelper.LogWarning($"{itemId} 키값을 가진 아이템 없음");
            return false;
        }

        foreach (Transform slot in inventorySlot.slotList)
        {
            if (slot.childCount == 0)
            {
                GameObject newItem = Instantiate(item.itemPrefab, slot);
                newItem.GetComponent<ItemHandler>().Init(item, amount);
                return true;
            }
        }
        return false;
    }

    public void OpenInventory()
    {
        inventorySlot.CreateSlots(CharacterManager.Instance.Player.InventorySlotCount);
    }
}