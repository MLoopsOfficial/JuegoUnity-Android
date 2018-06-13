using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarObjeto : MonoBehaviour {

	public float velX;
	public float velY;
	public float velZ;
	// Use this for initialization
	void Start () {
		float nrmX = velX * Time.deltaTime;
		float nrmY = velY * Time.deltaTime;
		float nrmZ = velZ * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (velX,velY,velZ);
	}
}
