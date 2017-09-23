using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public Camera camera;
//     private Vector3 cameraOffectPos = Vector3.zero;
//     private Vector3 cameraOriginPos = Vector3.zero;
//     private Vector3 cameraCurrentPos = Vector3.zero;

    // Use this for initialization
    void Start ()
    {
//         cameraCurrentPos = cameraOriginPos = camera.transform.position;
//         cameraOffectPos = cameraCurrentPos - cameraOriginPos;
    }
	
	// Update is called once per frame
	void Update ()
    {
//         cameraCurrentPos = camera.transform.position;
//         if (cameraCurrentPos != cameraOriginPos)
//         {
//             cameraOffectPos = cameraCurrentPos - cameraOriginPos;
//             cameraOriginPos = cameraCurrentPos;
//         }
        this.transform.forward = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
        //this.transform.position += cameraOffectPos;

    }
}
