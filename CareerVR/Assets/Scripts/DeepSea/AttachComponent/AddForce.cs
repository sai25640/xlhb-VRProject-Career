using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {

    private Rigidbody rigidbody;
	// Use this for initialization
	void Start ()
    {
        rigidbody = this.GetComponent<Rigidbody>();

    }

    private float timer;

	// Update is called once per frame
	void FixedUpdate ()
    {
        timer += Time.deltaTime;
      
        if (timer >= 5)
        {
            timer = 0;
            rigidbody.AddForce(Vector3.up * 10,ForceMode.Acceleration);
            Debug.Log("AddForce!"); 
        }
	}
}
