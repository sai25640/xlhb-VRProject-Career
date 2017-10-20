using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class MyTouchPadControl : VRTK_TouchpadControl {

    private void Start()
    {
        GetComponent<VRTK_ControllerEvents>().TouchpadPressed += new ControllerInteractionEventHandler(DoTouchpadPressed);
    }

    private bool flag = true;
    void DoTouchpadPressed(object sender, ControllerInteractionEventArgs e)
    {
        if (flag == false) return;

        UIManagerForMars.instance.ShowTip1();

        flag = false;
    }

    protected override void TouchpadAxisChanged(object sender, ControllerInteractionEventArgs e)
    {
        base.TouchpadAxisChanged(sender,e);
        //Debug.Log("Vector2 : " + currentAxis);

        if (currentAxis.y <= -0.8 && canPress == true)
        {
            UIManagerForMars.instance.SetCanvas(!UIManagerForMars.instance.CanvasIsShow());
            canPress = false;
        }
    }




    /// <summary>
    /// 开启计时器，不允许连续触发按钮事件
    /// </summary>
    private float timer = 0.3f;
    private bool canPress = true;
    private void Update()
    {
        timer -= Time.deltaTime;
        //Debug.Log(timer);
        if (timer <= 0)
        {
            canPress = true;
            timer = 1;
        }
    }
}
