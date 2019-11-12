using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_change : MonoBehaviour {

	public Camera cam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float r = 0;
		float g = 0;
		float b = 0;
		
		r = 220 + Mathf.PingPong(Time.time,35);
		g = 220 + Mathf.PingPong(Time.time,35);
		b = 220 + Mathf.PingPong(Time.time,35);
		cam.backgroundColor = new Color(r,g,b);

	}
}
