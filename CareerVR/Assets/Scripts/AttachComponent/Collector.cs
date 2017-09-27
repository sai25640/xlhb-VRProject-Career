using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.Highlighters;
public class Collector : MonoBehaviour {

    //public GameObject box; 
	void  OnTriggerStay (Collider other)
    {
        //标签为"Crystal"，并且是之前抓取过的可收集资源
        if (other.tag == "Crystal" && other.name == "CollectedCrystal")
        {
            if (other.GetComponent<VRTK_InteractableObject>().enabled == true)
            {
                Debug.Log("ColliderName = " + other.name);
                //解除这个矿石的交互脚本
                other.GetComponent<VRTK_InteractableObject>().enabled = false;
                other.GetComponent<VRTK_OutlineObjectCopyHighlighter>().enabled = false;
                //BoxCollider bc = other.GetComponent<BoxCollider>();
                //bc.enabled = false;
                Rigidbody rb = other.GetComponent<Rigidbody>();
                rb.useGravity = false;

                //添加自动隐藏动画脚本
                other.gameObject.AddComponent<HideSelf>();
            }


            ////Debug.Log("ColliderName = " + other.name);
            ////解除这个矿石的交互脚本
            //other.GetComponent<VRTK_InteractableObject>().enabled = false;
            //other.GetComponent<VRTK_OutlineObjectCopyHighlighter>().enabled = false;
            ////BoxCollider bc = other.GetComponent<BoxCollider>();
            ////bc.enabled = false;
            //Rigidbody rb = other.GetComponent<Rigidbody>();
            //rb.useGravity = false;

            ////添加自动隐藏动画脚本
            //other.gameObject.AddComponent<HideSelf>();

            //实时更新位置
            other.transform.parent = this.transform;
            other.transform.localPosition = Vector3.zero;
            other.transform.localRotation = Quaternion.identity;

                
        }
    }
}
