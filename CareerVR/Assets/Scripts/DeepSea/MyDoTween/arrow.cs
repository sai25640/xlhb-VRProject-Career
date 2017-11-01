using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class arrow : MonoBehaviour {

    private Transform arrowTrans;
    public float offectX;
    public float duration;
    // Use this for initialization
    void Start ()
    {
        arrowTrans = this.transform;

        arrowTrans.DOMove(new Vector3(arrowTrans.position.x + offectX, arrowTrans.position.y, arrowTrans.position.z), duration).SetEase(Ease.OutQuad).SetLoops(-1);
    }
	

}
