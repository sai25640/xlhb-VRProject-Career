using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MyPaths : MonoBehaviour {

    public Transform target;
    public PathType pathType = PathType.CatmullRom;
    public Transform[] waypoints = new Transform[] { };
    public float duration = 5;
 
    void Start ()
    {
        Vector3[] waypointsV3 = new Vector3[waypoints.Length];
        for (int i = 0;i<waypoints.Length;i++)
        {
            waypointsV3[i] = waypoints[i].position;
        }
      
        Tween t = target.DOPath(waypointsV3, duration, pathType)
            .SetOptions(true)
            .SetLookAt(0.001f);
        t.SetEase(Ease.Linear).SetLoops(-1);
    }
	
	
}
