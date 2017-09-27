using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class HideSelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.DOMoveY(this.transform.localPosition.y - 2f, 2f);
        Destroy(this.gameObject, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
