using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHighlightEffect : MonoBehaviour {

    private Button button;

	// Use this for initialization
	void Start () {
        button = this.GetComponent<Button>();
        EventTriggerListener.Get(button.gameObject).onEnter = OnEnterButton;
        EventTriggerListener.Get(button.gameObject).onExit = OnExitButton;
    }
	
	private void OnEnterButton(GameObject go)
    {
        if (go == button.gameObject)
        {
            go.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
    }

    private void OnExitButton(GameObject go)
    {
        if (go == button.gameObject)
        {
            go.gameObject.transform.localScale = Vector3.one;
        }
    }
}
