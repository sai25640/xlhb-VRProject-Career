using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerForMars : MonoBehaviour
{

    public static UIManagerForMars instance;
    public GameObject canvas;
    public GameObject cameraRig;
    private bool canvasIsShow = false;
    public GameObject modelController;
    private bool modelControllerIsShow = false;
    public GameObject cameraCanvas;

    private List<GameObject> modelInfoList = new List<GameObject>();
    private void Awake()
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

    public void HideCameraCanvas()
    {
        cameraCanvas.SetActive(false);
    }

    public void SetCanvas(bool show)
    {
        canvas.SetActive(show);
        canvasIsShow = show;
        //Debug.Log("canvasIsShow :"+ canvasIsShow);

        //同步跟随cameraRig的位置       
        canvas.transform.position = new Vector3(cameraRig.transform.position.x, 0.01f, cameraRig.transform.position.z);
        canvas.transform.forward = Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up);
    }
    public bool CanvasIsShow()
    {
        return canvasIsShow;
    }


    public void SetModelController(bool show)//GameObject touchedObject
    {
        //if (!touchedObject) return;
  
        modelController.SetActive(show);
        modelControllerIsShow = show;

        //同步跟随cameraRig的位置          
        modelController.transform.position = new Vector3(cameraRig.transform.position.x , 1.5f, cameraRig.transform.position.z);
        modelController.transform.forward = Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up);


    }

    public bool ModelControllerIsShow()
    {
        return modelControllerIsShow;
    }

    public void SetModelInfo(bool show , GameObject go)
    {
        {
            cameraCanvas.SetActive(show);
            GameObject info = Instantiate(Resources.Load("Prefabs/UI/Mars/" + go.tag)) as GameObject;
          
            info.transform.parent = cameraCanvas.transform;
            info.transform.localPosition = Vector3.zero;
            info.transform.localRotation = Quaternion.identity;
            info.transform.localScale = Vector3.one * 0.8f;

            //清空之前的列表
            if (modelInfoList.Count!= 0)
            {            
                for (int i = 0; i < modelInfoList.Count; i++)
                {
                    GameObject g = modelInfoList[i];
                    Destroy(g);
                }
            }
            //添加对象到空列表中
            modelInfoList.Add(info);

        }
    }

    public void HideModelInfo()
    {
        cameraCanvas.SetActive(false);
    }

    private bool scroeIsShow = false;
    public void ShowScore(string name)
    {
        if (scroeIsShow == true) return;

        cameraCanvas.SetActive(true);
        GameObject info = Instantiate(Resources.Load("Prefabs/UI/Mars/Job/" + name)) as GameObject;

        info.transform.parent = cameraCanvas.transform;
        info.transform.localPosition = Vector3.zero;
        info.transform.localRotation = Quaternion.identity;
        info.transform.localScale = Vector3.one;

        info.AddComponent<ReturenMainScene>();

        scroeIsShow = true;
    }
}