using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ItemController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static Vector2 DefaultPos;
    private Canvas canvas;
    
    private void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("PlayerUI").GetComponent<Canvas>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        DefaultPos = transform.position;
        transform.SetParent(canvas.transform);
        GetComponent<Image>().raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = eventData.position; 
        transform.position = currentPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = DefaultPos;
        GetComponent<Image>().raycastTarget = true;
    }
}