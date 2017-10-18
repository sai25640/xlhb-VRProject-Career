using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class MyInteractGrab : VRTK_InteractGrab
{
    public override void OnControllerGrabInteractableObject(ObjectInteractEventArgs e)
    {
        base.OnControllerGrabInteractableObject(e);

        //显示水晶的信息
        UIManagerForDeepSea.instance.Show(grabbedObject);
    }

    public override void OnControllerUngrabInteractableObject(ObjectInteractEventArgs e)
    {
        base.OnControllerUngrabInteractableObject(e);

        //隐藏水晶信息UI界面
        UIManagerForDeepSea.instance.Hide();

        //将水晶的Rigidbody设置成受重力影响并且加上Collider
        Rigidbody rg = grabbedObject.GetComponent<Rigidbody>();
        if (rg != null && rg.useGravity == false)
        {
            rg.useGravity = true;      
        }
       
        //将拾取的物体设置成可收集的资源
        grabbedObject.name = "CollectedCrystal";
    }


}
