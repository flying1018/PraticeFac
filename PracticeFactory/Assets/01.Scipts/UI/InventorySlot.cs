using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public GameObject slotPrefab; // Slot 프리팹
    public Transform slotParent; // 슬롯들을 담을 부모 오브젝트 (GridLayoutGroup)
    public int SlotCount = 12;

    private List<GameObject> slotList = new List<GameObject>();

    private void Start()
    {
        CreateSlots(SlotCount);
    }

    public void CreateSlots(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject newSlot = Instantiate(slotPrefab, slotParent);
            slotList.Add(newSlot);
        }
    }

    public int CurrentSlotCount()
    {
        return slotList.Count;
    }
}