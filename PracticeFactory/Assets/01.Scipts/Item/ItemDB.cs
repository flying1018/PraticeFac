using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<ItemInfo> itemList; // 아이템 정보들
    public static Dictionary<int, ItemInfo> itemDiction = new Dictionary<int, ItemInfo>();

    private void Awake()
    {
        itemDiction.Clear();
        foreach (ItemInfo item in itemList)
        {
            if (!itemDiction.ContainsKey(item.itemId)) { itemDiction.Add(item.itemId, item); }
        }
    }

    /// <summary>
    /// 아이템 정보가 필요할때 사용하는 메서드
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static ItemInfo GetItemInfo(int id)
    {
        if (itemDiction.ContainsKey(id)) { return itemDiction[id]; }
        else { DebugHelper.Log("잘못된 아이템ID 입력"); return itemDiction[999]; }
    }
}