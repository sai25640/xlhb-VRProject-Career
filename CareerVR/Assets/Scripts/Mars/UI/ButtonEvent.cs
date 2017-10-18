using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonEvent : MonoBehaviour {

    private Button button;
    public GameObject destroyTarget;
    private void Start()
    {
        button = this.GetComponent<Button>();
        EventTriggerListener.Get(button.gameObject).onClick = OnButtonClick;
            
    }

    private void OnButtonClick(GameObject go)
    {
        if (go == button.gameObject)
        {
            Destroy(destroyTarget);
        }
    }
}
