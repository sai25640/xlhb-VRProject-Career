using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.Highlighters;
public class Collector : MonoBehaviour
{

    //public GameObject box; 
    //void OnTriggerEnter(Collider other)
    //{
    //    //标签为"Crystal"，并且是之前抓取过的可收集资源
    //    if (other.gameObject.layer == LayerMask.NameToLayer("Crystal") && other.name == "CollectedCrystal")
    //    {
    //        if (other.GetComponent<VRTK_InteractableObject>().enabled == true)
    //        {
    //            //Debug.Log("ColliderName = " + other.name);
    //            //解除这个矿石的交互脚本
    //            other.GetComponent<VRTK_InteractableObject>().enabled = false;
    //            other.GetComponent<VRTK_OutlineObjectCopyHighlighter>().enabled = false;
    //            //BoxCollider bc = other.GetComponent<BoxCollider>();
    //            //bc.enabled = false;
    //            Rigidbody rb = other.GetComponent<Rigidbody>();
    //            rb.useGravity = false;

    //            //添加自动隐藏动画脚本
    //            other.gameObject.AddComponent<HideSelf>();
    //        }

    //        //更改采集数据
    //        switch (other.tag)
    //        {
    //            case "Rhodochrosite": CrystalData.rhodochrositeData += 100; break;
    //            case "Monazite": CrystalData.monaziteData += 100; break;
    //            case "CombustibleIce": CrystalData.combustibleIceData += 100; break;
    //            case "MetalMud": CrystalData.metalMudData += 100; break;
    //            case "Halobolite": CrystalData.haloboliteData += 100; break;
    //            case "Magnetite": CrystalData.magnetiteData += 100; break;
    //            case "Fluorite": CrystalData.fluoriteData += 100; break;
    //            case "Crystal": CrystalData.crystalData += 100; break;
    //        }

    //        //显示采集信息
    //        UIManager.Instance.ShowCollectInfo();
    //    }

    //}

    void OnTriggerStay(Collider other)
    {
        //标签为"Crystal"，并且是之前抓取过的可收集资源
        if (other.gameObject.layer == LayerMask.NameToLayer("Crystal") && other.name == "CollectedCrystal")
        {
            //标签为"Crystal"，并且是之前抓取过的可收集资源
            if (other.gameObject.layer == LayerMask.NameToLayer("Crystal") && other.name == "CollectedCrystal")
            {
                if (other.GetComponent<VRTK_InteractableObject>().enabled == true)
                {
                    //Debug.Log("ColliderName = " + other.name);
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

                //更改采集数据
                switch (other.tag)
                {
                    case "Rhodochrosite": CrystalData.rhodochrositeData += 100; break;
                    case "Monazite": CrystalData.monaziteData += 100; break;
                    case "CombustibleIce": CrystalData.combustibleIceData += 100; break;
                    case "MetalMud": CrystalData.metalMudData += 100; break;
                    case "Halobolite": CrystalData.haloboliteData += 100; break;
                    case "Magnetite": CrystalData.magnetiteData += 100; break;
                    case "Fluorite": CrystalData.fluoriteData += 100; break;
                    case "Crystal": CrystalData.crystalData += 100; break;
                }

                //显示采集信息
                UIManager.Instance.ShowCollectInfo();


                //实时更新位置
                other.transform.parent = this.transform;
                other.transform.localPosition = Vector3.zero;
                other.transform.localRotation = Quaternion.identity;


            }
        }
    }
}
