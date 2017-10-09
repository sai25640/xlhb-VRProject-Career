using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturenMainScene : MonoBehaviour {

	public float time = 8f;

	void Start ()
    {
        Invoke("ReturenToMainScene", time);
	}
	
    void ReturenToMainScene()
    {
        SceneManager.LoadScene("LoginScene");
    }
}
