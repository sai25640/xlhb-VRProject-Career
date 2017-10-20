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
    public GameObject tips1;
    public GameObject cameraCanvas;

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

    public void ShowTip1()
    {
        tips1.SetActive(true);
        Invoke("HideCameraCanvas", 5f);
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
}