using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryState : MonoBehaviour
{
    public void OnEnter()
    {
        UIManager.Instance.ShowInventory();
        UIManager.Instance.ShowEquipment();
        UIManager.Instance.ShowChest();
    }

    public void OnUpdate() { }

    public void OnExit()
    {
        UIManager.Instance.HideInventory();
        UIManager.Instance.HideEquipment();
        UIManager.Instance.HideChest();
    }
}

