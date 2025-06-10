using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerDragDrop : MonoBehaviour
{
    [SerializeField] public Image itemImage;
    [SerializeField] public SlotHandler slotHandler; // 현재 드래그중인 아이템 정보

    [SerializeField] private GameObject draggingIcon;
    [SerializeField] private Canvas PlayerUI;

    private bool isDrag;

    private void OnClick(InputAction.CallbackContext context)
    {
        if (slotHandler.itemId == -1 || isDrag) return;

        if (context.phase == InputActionPhase.Started)
        {
            draggingIcon = new GameObject("DraggingIcon", typeof(Image));
            draggingIcon.transform.SetParent(PlayerUI.transform, false);
        }
    }

    private void OnDrag(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {

        }
    }

    private void OnDrop(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Canceled)
        {

        }
    }
}