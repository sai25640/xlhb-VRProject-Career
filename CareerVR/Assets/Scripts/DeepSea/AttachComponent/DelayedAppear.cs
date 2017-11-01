using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedAppear : MonoBehaviour {

    public float delayTime =0;
	// Use this for initialization
	void Awake ()
    {
        Invoke("SetActiveSelf", delayTime);
        this.gameObject.SetActive(false);
	}
	
	void SetActiveSelf()
    {
        this.gameObject.SetActive(true);
    }
}
