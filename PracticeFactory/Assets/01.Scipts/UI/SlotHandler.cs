using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class SlotHandler : MonoBehaviour
{
    public int slotNum { get; private set; }
    public int itemId { get; private set; }
    public int Amount { get; private set; }

    public void SetSlot(int slot, int amount, int Id = 1)
    {
        slotNum = slot;
        itemId = Id;
        Amount = amount;
    }
}