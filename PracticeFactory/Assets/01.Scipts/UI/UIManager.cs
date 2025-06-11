using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject InventoryUI;
    [SerializeField] private GameObject EquipmentUI;
    [SerializeField] private GameObject chestUI;
    private static UIManager _instance;
    public static UIManager Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance != this)
            {
                Destroy(gameObject);
            }
        }
        DebugHelper.Log("UI매니저 Awake");
    }

    public void Init() { }

    public void ShowInventory()
    {
        if (InventoryUI != null)
            InventoryUI.SetActive(true);
        
        ItemManager.Instance.Inventory.OpenInventory();
    }

    public void HideInventory()
    {
        if (InventoryUI != null)
            InventoryUI.SetActive(false);
    }

    public void ShowEquipment()
    {
        if (EquipmentUI != null)
            EquipmentUI.SetActive(true);
    }

    public void HideEquipment()
    {
        if (EquipmentUI != null)
            EquipmentUI.SetActive(false);
    }

    public void ShowChest()
    {
        if (chestUI != null)
            chestUI.SetActive(true);
    }

    public void HideChest()
    {
        if (chestUI != null)
            chestUI.SetActive(false);
    }
}
