using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

    public class SeatController : MonoBehaviour, IDropHandler
    {
        public Text dialogue;
        public string residentName;
		
        // 오브젝트가 드롭되었을 시 호출되는 함수
        public void OnDrop(PointerEventData eventData)
        {

        }
    }