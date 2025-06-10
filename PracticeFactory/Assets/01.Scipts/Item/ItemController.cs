using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ItemController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Canvas canvas;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    private Transform originalParent;

    void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("PlayerUI").GetComponent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;

        transform.SetParent(canvas.transform); // 드래그 중엔 최상단으로
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = eventData.position; 
        rectTransform.position = currentPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (transform.parent == canvas.transform)
        {
            transform.SetParent(originalParent);
            rectTransform.anchoredPosition = Vector2.zero;
        }

        canvasGroup.blocksRaycasts = true;
    }
}