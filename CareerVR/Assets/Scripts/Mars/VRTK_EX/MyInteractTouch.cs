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
            UIManagerForMars.instance.SetModelController(!UIManagerForMars.instance.ModelControllerIsShow());//touchedObject

            //Debug.Log("SetModelController");
        }
 
    }

    public override void OnControllerTouchInteractableObject(ObjectInteractEventArgs e)
    {
        base.OnControllerTouchInteractableObject(e);
        isTouch = true;

        buttonEvent.target = touchedObject;
        buttonEvent.AttachTarget();
    }

    public override void OnControllerUntouchInteractableObject(ObjectInteractEventArgs e)
    {
        base.OnControllerUntouchInteractableObject(e);
        isTouch = false;

        //buttonEvent.target = null;
    }

}
