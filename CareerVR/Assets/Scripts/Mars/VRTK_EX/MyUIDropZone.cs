using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using VRTK;
public class MyUIDropZone : VRTK_UIDropZone {

	public override void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag)
        {
            //Debug.Log("pointerDrag :" + eventData.pointerDrag);
            var dragItem = eventData.pointerDrag.GetComponent<MyUIDraggableItem>();
            if (dragItem && dragItem.restrictToDropZone)
            {
                //Debug.Log("validDropZone :" + gameObject);
                dragItem.validDropZone = gameObject;
                droppableItem = dragItem;
            }
        }
    }
}
