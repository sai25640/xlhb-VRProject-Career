using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fog : MonoBehaviour {

    //public bool defaultFog = RenderSettings.fog;
    public Color fogColor = new Color(0, 0.4f, 0.7f, 0.6f);
    public float fogDensity = 0.02f;

    // Use this for initialization
    void Start () {
        RenderSettings.fogColor = new Color(0, 0.4f, 0.7f,0.6f);
        RenderSettings.fogDensity = 0.04f;
        //RenderSettings.fogMode = FogMode.Linear;
        RenderSettings.fog = true;


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
