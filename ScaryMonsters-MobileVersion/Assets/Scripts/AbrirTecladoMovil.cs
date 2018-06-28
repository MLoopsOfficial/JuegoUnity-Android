using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class AbrirTecladoMovil : MonoBehaviour {

	private TouchScreenKeyboard teclado;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		openKeyboard ();
		if (teclado != null) {
			if (Input.deviceOrientation == DeviceOrientation.FaceDown)
				teclado.active = false;
			if (Input.deviceOrientation == DeviceOrientation.FaceUp)
				teclado.active = true;
		}
	}
	void openKeyboard()
	{
		teclado.active = true;
		TouchScreenKeyboard.Open("", TouchScreenKeyboardType.EmailAddress, false, false, true, true);
	}

}
