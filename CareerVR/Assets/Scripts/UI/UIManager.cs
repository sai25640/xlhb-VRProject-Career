using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : GenericSingletonClass<UIManager> {

    public GameObject canvas;

    
    void Start()
    {
        //进入深海显示注意信息
        //GameObject image = Instantiate(Resources.Load("Prefabs/UI/Tips0")) as GameObject;
        //image.transform.parent = canvas.transform;
        //RectTransform rt = image.GetComponent<Image>().GetComponent<RectTransform>();
        //rt.anchoredPosition3D = Vector3.zero;
        //rt.localRotation = Quaternion.identity;
        //rt.localScale = Vector3.one;
        //canvas.SetActive(true);
    }

    //显示物品信息
    public void Show(GameObject go)
    {
        
        //随机显示UI面板信息内容
        int random = Random.Range(0, 2);
        GameObject image = Instantiate(Resources.Load("Prefabs/UI/" + go.tag + random.ToString())) as GameObject;
       
        Debug.Log("Prefabs/UI/" + go.tag + random.ToString());
        Debug.Log("image =" + image.name);
        image.transform.parent = canvas.transform;
        RectTransform rt = image.GetComponent<Image>().GetComponent<RectTransform>();
        rt.anchoredPosition3D = Vector3.zero;
        rt.localRotation = Quaternion.identity;
        rt.localScale = Vector3.one;
      
        canvas.SetActive(true);

    }

    //隐藏物品信息
    public void Hide()
    {
        //清除UI面板信息
        canvas.transform.DetachChildren();
        canvas.SetActive(false);
    }

    //显示当前采集数量
    public void ShowCollectInfo()
    {
        GameObject image = Instantiate(Resources.Load("Prefabs/UI/CollectInfo")) as GameObject;

        image.transform.parent = canvas.transform;
        RectTransform rt = image.GetComponent<Image>().GetComponent<RectTransform>();
        rt.anchoredPosition3D = Vector3.zero;
        rt.localRotation = Quaternion.identity;
        rt.localScale = Vector3.one;

        canvas.SetActive(true);
     
    }

}
