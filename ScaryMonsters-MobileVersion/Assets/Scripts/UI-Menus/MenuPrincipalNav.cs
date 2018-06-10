using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPrincipalNav : MonoBehaviour {

	public Image[] opciones;
	public int opcionPorDefecto=1;
	private int opcionActual=0;

	void Start () {
		opcionActual = opcionPorDefecto;
	}

	void Update () {
		
	}
}
