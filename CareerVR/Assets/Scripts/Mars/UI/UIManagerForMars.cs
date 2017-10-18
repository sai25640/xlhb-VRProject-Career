﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerForMars : MonoBehaviour
{

    public static UIManagerForMars instance;
    public GameObject canvas;
    public GameObject cameraRig;
    private bool canvasIsShow = false;
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
    private void Start()
    {
        //SetCanvas(false);
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

    //public void HideCanvas()
    //{
    //    canvas.SetActive(false);
    //}

    public void OnButton1Click()
    {
        Debug.Log("button1");
    }

}