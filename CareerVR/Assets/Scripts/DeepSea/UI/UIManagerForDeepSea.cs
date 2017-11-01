using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManagerForDeepSea : MonoBehaviour {

    public static UIManagerForDeepSea instance;
    public GameObject canvas;
    public float uiScale =0.8f;
    private List<GameObject> uiList = new List<GameObject>();
    void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    //显示Tip0
    public void ShowTip0()
    {

    }



    //显示物品信息
    public void Show(GameObject go)
    {
        int max = 0;
        //随机显示UI面板信息内容
        switch (go.tag)
        {
            case "Rhodochrosite": max = 0; break;
            case "Monazite": max = 1; break;
            case "CombustibleIce": max = 1; break;
            case "MetalMud": max = 0; break;
            case "Halobolite": max = 1; break;
            case "Magnetite": max = 1; break;
            case "Fluorite": max = 2; break;
            case "Crystal": max = 2; break;

        }
        int random = Random.Range(0, max);
        GameObject image = Instantiate(Resources.Load("Prefabs/UI/DeepSea/" + go.tag + random.ToString())) as GameObject;
       
        //Debug.Log("Prefabs/UI/" + go.tag + random.ToString());
        //Debug.Log("image =" + image.name);
        image.transform.parent = canvas.transform;
        RectTransform rt = image.GetComponent<Image>().GetComponent<RectTransform>();
        rt.anchoredPosition3D = Vector3.zero;
        rt.localRotation = Quaternion.identity;
        rt.localScale = Vector3.one * uiScale;
      
        canvas.SetActive(true);

    }

    //隐藏物品信息
    public void Hide()
    {
        //清除UI面板信息
        canvas.transform.GetChild(0).gameObject.AddComponent<DestroySelf>();
        canvas.transform.DetachChildren();
        canvas.SetActive(false);
    }

    //显示当前采集数量
    public void ShowCollectInfo()
    {
        GameObject image = Instantiate(Resources.Load("Prefabs/UI/DeepSea/CollectInfo")) as GameObject;

        image.transform.parent = canvas.transform;
        RectTransform rt = image.GetComponent<Image>().GetComponent<RectTransform>();
        rt.anchoredPosition3D = Vector3.zero;
        rt.localRotation = Quaternion.identity;
        rt.localScale = Vector3.one * uiScale;

        canvas.SetActive(true);
     
    }

    bool isShowOneMinute = true;
    //显示提示1分钟界面
    public void ShowOneMinute()
    {
        if (isShowOneMinute)
        {
            isShowOneMinute = false;

            GameObject image = Instantiate(Resources.Load("Prefabs/UI/DeepSea/Tips_OneMinute")) as GameObject;

            image.transform.parent = canvas.transform;
            RectTransform rt = image.GetComponent<Image>().GetComponent<RectTransform>();
            rt.anchoredPosition3D = Vector3.zero;
            rt.localRotation = Quaternion.identity;
            rt.localScale = Vector3.one * uiScale;

            canvas.SetActive(true);
        }
    }

    //显示最终分数
    public void ShowScore(int score)
    {
        GameObject image = Instantiate(Resources.Load("Prefabs/UI/DeepSea/Tips_Score")) as GameObject;

        image.transform.parent = canvas.transform;
        RectTransform rt = image.GetComponent<Image>().GetComponent<RectTransform>();
        rt.anchoredPosition3D = Vector3.zero;
        rt.localRotation = Quaternion.identity;
        rt.localScale = Vector3.one * uiScale;
        
        //给Text设置分数
        image.transform.GetChild(1).GetComponent<Text>().text = score + "分";

        canvas.SetActive(true);
    }

}
