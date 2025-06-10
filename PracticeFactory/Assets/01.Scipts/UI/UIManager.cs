using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private GameObject InventoryUI;
    private GameObject EquipmentUI;
    private GameObject chestUI;
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("UIManager").AddComponent<UIManager>();
            }
            return _instance;
        }
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
        InventoryUI = GameObject.FindGameObjectWithTag("InventoryUI");
        EquipmentUI = GameObject.FindGameObjectWithTag("EquipmentUI");
        chestUI = GameObject.FindGameObjectWithTag("chestUI");
    }

    public void Init() { }

    public void ShowInventory()
    {
        InventoryUI.SetActive(true);
    }

    public void HideInventory()
    {
        InventoryUI.SetActive(false);
    }
}
