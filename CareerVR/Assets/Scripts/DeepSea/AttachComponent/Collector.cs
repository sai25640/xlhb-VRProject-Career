using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.Highlighters;
public class Collector : MonoBehaviour
{

    //public GameObject box; 
    void OnTriggerEnter(Collider other)
    {
        //标签为"Crystal"，并且是之前抓取过的可收集资源
        if (other.gameObject.layer == LayerMask.NameToLayer("Crystal") && other.name == "CollectedCrystal")
        {
            //if (other.GetComponent<VRTK_InteractableObject>().enabled == true)
            //{
            //    //Debug.Log("ColliderName = " + other.name);
            //    //解除这个矿石的交互脚本
            //    other.GetComponent<VRTK_InteractableObject>().enabled = false;
            //    other.GetComponent<VRTK_OutlineObjectCopyHighlighter>().enabled = false;
            //    //BoxCollider bc = other.GetComponent<BoxCollider>();
            //    //bc.enabled = false;
            //    Rigidbody rb = other.GetComponent<Rigidbody>();
            //    rb.useGravity = false;

            //    //添加自动隐藏动画脚本
            //    other.gameObject.AddComponent<HideSelf>();
            //}

            //更改采集数据
            //switch (other.tag)
            //{
            //    case "Rhodochrosite": CrystalData.rhodochrositeData += 100; break;
            //    case "Monazite": CrystalData.monaziteData += 100; break;
            //    case "CombustibleIce": CrystalData.combustibleIceData += 100; break;
            //    case "MetalMud": CrystalData.metalMudData += 100; break;
            //    case "Halobolite": CrystalData.haloboliteData += 100; break;
            //    case "Magnetite": CrystalData.magnetiteData += 100; break;
            //    case "Fluorite": CrystalData.fluoriteData += 100; break;
            //    case "Crystal": CrystalData.crystalData += 100; break;
            //}

            ////显示采集信息
            //UIManager.Instance.ShowCollectInfo();

            //Debug.Log("CrystalData.rhodochrositeData = " + CrystalData.rhodochrositeData);
            //Debug.Log("CrystalData.monaziteData = " + CrystalData.monaziteData);
            //Debug.Log("CrystalData.combustibleIceData = " + CrystalData.combustibleIceData);
            //Debug.Log("CrystalData.metalMudData = " + CrystalData.metalMudData);
            //Debug.Log("CrystalData.haloboliteData = " + CrystalData.haloboliteData);
            //Debug.Log("CrystalData.magnetiteData = " + CrystalData.magnetiteData);
            //Debug.Log("CrystalData.fluoriteData = " + CrystalData.fluoriteData);
            //Debug.Log("CrystalData.crystalData = " + CrystalData.crystalData);
        }

    }

    void OnTriggerStay(Collider other)
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
                    Debug.Log("other.tag =" + other.tag);

                //更改采集数据
                switch (other.tag)
                {
                    case "Rhodochrosite": CrystalData.rhodochrositeData += Random.Range(5,8); break;
                    case "Monazite": CrystalData.monaziteData += Random.Range(5, 8); break;
                    case "CombustibleIce": CrystalData.combustibleIceData += Random.Range(5, 8); break;
                    case "MetalMud": CrystalData.metalMudData += Random.Range(5, 8); break;
                    case "Halobolite": CrystalData.haloboliteData += Random.Range(5, 8); break;
                    case "Magnetite": CrystalData.magnetiteData += Random.Range(5, 8); break;
                    case "Fluorite": CrystalData.fluoriteData += Random.Range(5, 8); break;
                    case "Crystal": CrystalData.crystalData += Random.Range(5, 8); break;
                }

                //显示采集信息
                UIManagerForDeepSea.instance.ShowCollectInfo();

                //Debug.Log("CrystalData.rhodochrositeData = " + CrystalData.rhodochrositeData);
                //Debug.Log("CrystalData.monaziteData = " + CrystalData.monaziteData);
                //Debug.Log("CrystalData.combustibleIceData = " + CrystalData.combustibleIceData);
                //Debug.Log("CrystalData.metalMudData = " + CrystalData.metalMudData);
                //Debug.Log("CrystalData.haloboliteData = " + CrystalData.haloboliteData);
                //Debug.Log("CrystalData.magnetiteData = " + CrystalData.magnetiteData);
                //Debug.Log("CrystalData.fluoriteData = " + CrystalData.fluoriteData);
                //Debug.Log("CrystalData.crystalData = " + CrystalData.crystalData);

                other.name = "unCollectedCrystal";
            }
            
            
            //实时更新位置
            other.transform.parent = this.transform;
            other.transform.localPosition = Vector3.zero;
            other.transform.localRotation = Quaternion.identity;


            
        }
    }
}
