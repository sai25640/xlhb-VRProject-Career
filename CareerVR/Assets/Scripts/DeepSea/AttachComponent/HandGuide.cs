using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGuide : MonoBehaviour {

    public Transform target;
    public GameObject arrow;
    private GameObject canvas;
    public GameObject htcHandle;
    void Start()
    {
        canvas = this.transform.Find("Canvas").gameObject;
        canvas.SetActive(false);
    }
    // Update is called once per frame
	void Update ()
    {
        if (target != null)
        {
            float distance = Vector3.Distance(target.position, this.transform.position);
            if (distance<=2.5)
            {
                //Debug.Log("靠近了");
                if (canvas) canvas.SetActive(true);                
                if (htcHandle) htcHandle.SetActive(true);    
            }
            else
            {
                //Debug.Log("离远了");
                //arrow.SetActive(false);
            }
          
        }
	}
}
