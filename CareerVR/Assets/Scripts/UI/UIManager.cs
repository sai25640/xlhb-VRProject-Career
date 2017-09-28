using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : GenericSingletonClass<UIManager> {

    public GameObject canvas;
    public Text text;

    ////////////////////////////////////////////////////////深海场景//////////////////////////////////////////////////////////////
    //显示物品信息
    public void Show(GameObject go)
    {
        text.text = go.GetComponent<ObjectInfo>().info;
        canvas.SetActive(true);
    }

    //隐藏物品信息
    public void Hide()
    {
        text.text = "";
        canvas.SetActive(false);
    }


    ////////////////////////////////////////////////////////登陆场景//////////////////////////////////////////////

    public void OnLoginButtonClick()
    {
        Debug.Log(" OnLoginButtonClick!");
    }
}
