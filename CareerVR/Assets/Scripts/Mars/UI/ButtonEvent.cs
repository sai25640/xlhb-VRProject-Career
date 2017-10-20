using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonEvent : MonoBehaviour {

    private Slider postionYSlider;
    private Slider rotationSlider;
    private Slider scaleSlider;
    private Button deleteButton;
    public GameObject target;
    private float targetOriginScale;
    private float targetOriginY;
    
    private void Start()
    {
        //移除按钮
        deleteButton = transform.Find("DeleteButton").GetComponent<Button>();  
        //EventTriggerListener.Get(deleteButton.gameObject).onClick = OnButtonClick;

        //高度Slider
        postionYSlider = transform.Find("PostionYSlider").GetComponent<Slider>();
        //旋转Slider
        rotationSlider = transform.Find("RotationSlider").GetComponent<Slider>();
        //缩放Slider
        scaleSlider = transform.Find("ScaleSlider").GetComponent<Slider>();

        //保持原始大小位置
        if (target != null)
        {
            targetOriginScale = target.transform.localScale.z;
            targetOriginY = target.transform.localPosition.y;
            Debug.Log("targetOriginTrans.localScale.z =" + targetOriginScale);
        }
    }

    public void AttachTarget()
    {
        //保持原始大小位置
        if (target != null)
        {
            targetOriginScale = target.transform.localScale.z;
            targetOriginY = target.transform.localPosition.y;
            //Debug.Log("targetOriginTrans.localScale.z =" + targetOriginScale);
        }
    }

    public void OnDeleteButtonClick()
    {
        Destroy(target);
        UIManagerForMars.instance.SetModelController(false);
    }

    public void OnRotationSliderValueChanged()
    {
        Vector3 angle = target.transform.eulerAngles;
        angle.y = rotationSlider.value * 360f;
        target.transform.eulerAngles = angle;

    }

    public void OnScaleSliderValueChanged()
    {

        // （0~1）+1 = （1~2）   50
        //Debug.Log("targetOriginTrans.localScale.z =" + targetOriginScale);
        float scaleOffect = scaleSlider.value - 0.5f;
        float targetScale = target.transform.localScale.x + scaleOffect;
        if (targetScale >= targetOriginScale * 1.5f)
        {
            targetScale = targetOriginScale * 1.5f;
        }
        else if (targetScale <= targetOriginScale / 1.5f)
        {
            targetScale = targetOriginScale / 1.5f;
        }
   
        target.transform.localScale = new Vector3(targetScale, targetScale, targetScale);
    }

    public void OnPostionYSliderValueChanged()
    {
        // (0~1) - 0.5 = (-0.5 ~ 0.5)
        float yOffect = postionYSlider.value -0.5f;
        float targetY = target.transform.localPosition.y + yOffect;
        if (targetY >= targetOriginY+1)
        {
            targetY = targetOriginY + 1;
        }
        else if (targetY <= targetOriginY - 1)
        {
            targetY = targetOriginY - 1;
        }
        target.transform.localPosition = new Vector3(target.transform.localPosition.x, targetY, target.transform.localPosition.z);
        
    }
}
