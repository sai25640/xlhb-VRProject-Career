using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : GenericSingletonClass<UIManager> {

    public GameObject canvas;
    public Text text;

    public void Show(GameObject go)
    {
        text.text = go.GetComponent<ObjectInfo>().info;
        canvas.SetActive(true);
    }

    public void Hide()
    {
        text.text = "";
        canvas.SetActive(false);
    }
}
