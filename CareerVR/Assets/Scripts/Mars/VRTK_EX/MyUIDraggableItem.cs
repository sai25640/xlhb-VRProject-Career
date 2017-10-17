using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using VRTK;
public class MyUIDraggableItem : VRTK_UIDraggableItem
{
    private GameObject clone;
    public GameObject buildPrefab;
    public GameObject buildList;
    public override void OnBeginDrag(PointerEventData eventData)
    {
        //base.OnBeginDrag(eventData);
        //克隆对象
        CloneElement();
       
        startPosition = transform.position;
        startRotation = transform.rotation;
        startParent = transform.parent;
        startCanvas = GetComponentInParent<Canvas>();
        canvasGroup.blocksRaycasts = false;

        if (restrictToDropZone)
        {
            startDropZone = GetComponentInParent<VRTK_UIDropZone>().gameObject;
            validDropZone = startDropZone;
        }

        SetDragPosition(eventData);
        VRTK_UIPointer pointer = GetPointer(eventData);
        if (pointer != null)
        {
            pointer.OnUIPointerElementDragStart(pointer.SetUIPointerEvent(pointer.pointerEventData.pointerPressRaycast, gameObject));
        }
        //Debug.Log("DragObject :" + eventData.pointerEnter.name);
        //Debug.Log("startParent :" + startParent.name);
        //Debug.Log("Vector2 :"+eventData.position);
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        dragTransform = null;
        transform.position += (transform.forward * forwardOffset);
        bool validDragEnd = true;
       
        if (restrictToDropZone)
        {
            if (validDropZone != null && validDropZone != startDropZone)
            {
                transform.SetParent(validDropZone.transform);
                //开始生成建筑
                Debug.Log("开始生成建筑:" + gameObject);
                GameObject build = Instantiate(buildPrefab, validDropZone.transform) as GameObject;
                build.transform.parent = buildList.transform;
                build.transform.localPosition = new Vector3(build.transform.localPosition.x, 1.1f, build.transform.localPosition.z);
                build.transform.localScale = Vector3.one * 50;
                build.transform.localRotation = Quaternion.identity;
                build.SetActive(true);
            }
            else
            {
                ResetElement();
                //销毁克隆对象
                Destroy(clone);
                validDragEnd = false;
            }
        }

        Canvas destinationCanvas = (eventData.pointerEnter != null ? eventData.pointerEnter.GetComponentInParent<Canvas>() : null);
        if (restrictToOriginalCanvas)
        {
            if (destinationCanvas != null && destinationCanvas != startCanvas)
            {
                ResetElement();
                //销毁克隆对象
                Destroy(clone);
                validDragEnd = false;
            }
        }

        if (destinationCanvas == null)
        {
            //We've been dropped off of a canvas
            ResetElement();
            //销毁克隆对象
            Destroy(clone);
            validDragEnd = false;
        }

        if (validDragEnd)
        {
            VRTK_UIPointer pointer = GetPointer(eventData);
            if (pointer != null)
            {
                pointer.OnUIPointerElementDragEnd(pointer.SetUIPointerEvent(pointer.pointerEventData.pointerPressRaycast, gameObject));
            }        
            OnDraggableItemDropped(SetEventPayload(validDropZone));
            Debug.Log("validDropZone :" + validDropZone.transform);
            //开始生成建筑
            //Debug.Log("开始生成建筑:" + gameObject);
            //GameObject build = Instantiate(buildPrefab, validDropZone.transform) as GameObject;
            //build.transform.parent = buildList.transform;
            //build.transform.localPosition = new Vector3(build.transform.localPosition.x, 1.1f, build.transform.localPosition.z);
            //build.transform.localScale = Vector3.one * 50;
            //build.transform.localRotation = Quaternion.identity;
            //build.SetActive(true);
        }

        validDropZone = null;
        startParent = null;
        startCanvas = null;
    }

    //克隆对象
    protected void CloneElement()
    {
        //transform.gameObject
        //transform.position = startPosition;
        //transform.rotation = startRotation;
        //transform.SetParent(startParent);
        //OnDraggableItemReset(SetEventPayload(startParent.gameObject));

        clone = Instantiate(this.gameObject, transform);
        clone.transform.SetParent(transform.parent);
        clone.transform.position = transform.position;
        clone.transform.rotation = transform.rotation;
    }
}
