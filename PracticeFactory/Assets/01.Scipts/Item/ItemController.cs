using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemController : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    Vector3 DefaultPos;
	
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) // 드래그 클릭시 호출
    {
        DefaultPos = transform.position; // 초기 위치 정보
        GetComponent<Image>().raycastTarget = false; 
    }
	
    // 드래그 중
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector3 currentPos = Camera.main.ScreenToWorldPoint(eventData.position);
        this.transform.position = currentPos;
    }
	
    // 드래그 끝
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        this.transform.position = DefaultPos;
        GetComponent<Image>().raycastTarget = true;
    }
}
