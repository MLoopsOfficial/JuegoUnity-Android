using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaInicioToque : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				Debug.Log ("Tocaste la pantalla xD");
			}
			if(Input.GetTouch(0).phase == TouchPhase.Moved){
				Debug.Log ("Moviendo Pantalla xD x2");
			}
			if(Input.GetTouch(0).phase == TouchPhase.Ended){
				Debug.Log ("Dejaste de tocar Pantalla xD");
			}
		}
	}
}
