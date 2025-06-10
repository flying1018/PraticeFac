using UnityEngine;
using UnityEngine.EventSystems;

public class SlotHandler : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropItem = eventData.pointerDrag;

        if (dropItem != null)
        {
            dropItem.transform.SetParent(this.transform);
            dropItem.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        }
    }
}