using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlaySlow : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        this.GetComponent<Animation>()["Take 001"].speed = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
