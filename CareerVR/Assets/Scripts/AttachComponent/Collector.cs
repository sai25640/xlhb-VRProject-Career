using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {

    public GameObject box; 
	void  OnTriggerEnter (Collider other)
    {
        if (other.tag == "Crystal" && other.name == "CollectedCrystal")
        {
            Debug.Log("ColliderName = " + other.name);
            BoxCollider bc = other.GetComponent<BoxCollider>();
            bc.enabled = false;
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.useGravity = false;

          
            other.transform.parent = box.transform;
            other.transform.localPosition = Vector3.zero;
            other.transform.localRotation = Quaternion.identity;
            other.transform.localScale = Vector3.one * 0.5f;
            Debug.Log("localPosition = " + other.transform.localPosition);
            Debug.Log("localRotation = " + other.transform.localRotation);


        }
    }
}
