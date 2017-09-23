using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatewithCamera : MonoBehaviour {

    public Camera camera;
    //private float x,y,z;
    
	// Use this for initialization
	void Start ()
    {
        //x = camera.transform.localRotation.x;
        //y = camera.transform.localRotation.y;
        //z = camera.transform.localRotation.z;
    }
	
	// Update is called once per frame
	void Update ()
    {
     
        this.transform.forward = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
	}
}
