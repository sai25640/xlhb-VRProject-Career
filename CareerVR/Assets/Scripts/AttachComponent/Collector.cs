using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {

    //public GameObject box; 
	void  OnTriggerEnter (Collider other)
    {
        //标签为"Crystal"，并且是之前抓取过的可收集资源
        if (other.tag == "Crystal" && other.name == "CollectedCrystal")
        {
            Debug.Log("ColliderName = " + other.name);
            BoxCollider bc = other.GetComponent<BoxCollider>();
            bc.enabled = false;
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.useGravity = false;

            
            other.transform.parent = this.transform;
            other.transform.localPosition = Vector3.zero;
            other.transform.localRotation = Quaternion.identity;

            //添加自动隐藏动画脚本
            other.gameObject.AddComponent<HideSelf>();
            //other.transform.localScale = Vector3.one;
            //Debug.Log("localPosition = " + other.transform.localPosition);
            //Debug.Log("localRotation = " + other.transform.localRotation);


        }
    }
}
