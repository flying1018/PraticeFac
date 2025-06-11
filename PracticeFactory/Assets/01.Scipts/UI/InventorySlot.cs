using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public GameObject slotPrefab; // Slot 프리팹
    public Transform slotParent; // 슬롯들을 담을 부모 오브젝트

    public List<Transform> slotList = new List<Transform>();

    public void CreateSlots(int count)
    {
        foreach (Transform child in slotParent)
        {
            Destroy(child.gameObject);
        }
        slotList.Clear();
        
        for (int i = 0; i < count; i++)
        {
            GameObject newSlot = Instantiate(slotPrefab, slotParent);
            slotList.Add(newSlot.transform);
        }
    }

    public int CurrentSlotCount()
    {
        return slotList.Count;
    }
}