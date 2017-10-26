using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class MyInteractTouch : VRTK_InteractTouch
{
    public ButtonEvent buttonEvent;

    private void Start()
    {
        GetComponent<VRTK_ControllerEvents>().TriggerPressed += new ControllerInteractionEventHandler(DoTriggerPressed);
    }

    private bool isTouch = false;
    public void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
        if (isTouch == true)
        {
            //显示操控面板
            UIManagerForMars.instance.SetModelController(!UIManagerForMars.instance.ModelControllerIsShow());//touchedObject

            //关闭建筑面板
            UIManagerForMars.instance.SetCanvas(false);
        }
 
    }

    public override void OnControllerStartUntouchInteractableObject(ObjectInteractEventArgs e)
    {
        base.OnControllerStartTouchInteractableObject(e);  
    }

    public override void OnControllerTouchInteractableObject(ObjectInteractEventArgs e)
    {
        //如果游戏结束就不让弹出信息面板了
        if (GameManagerForMars.instance.GameIsOver() == true) return;

        base.OnControllerTouchInteractableObject(e);
        isTouch = true;

        //绑定当前聚焦的对象是哪个建筑物体
        buttonEvent.target = touchedObject;
        buttonEvent.AttachTarget();

        //显示信息面板
        Debug.Log("显示信息面板");
        UIManagerForMars.instance.SetModelInfo(true,touchedObject);
    }

    public override void OnControllerUntouchInteractableObject(ObjectInteractEventArgs e)
    {
        //如果游戏结束就不让弹出信息面板了
        if (GameManagerForMars.instance.GameIsOver() == true) return;

        base.OnControllerUntouchInteractableObject(e);
        isTouch = false;

        //关闭信息面板
        //Debug.Log("关闭信息面板");
        UIManagerForMars.instance.HideCameraCanvas();
    }

}
