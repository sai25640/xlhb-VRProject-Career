using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public Camera camera;

	void Update ()
    {
        this.transform.forward = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
        this.transform.localPosition = new Vector3(camera.transform.localPosition.x , 0.4f , camera.transform.localPosition.z);   
    }
}
