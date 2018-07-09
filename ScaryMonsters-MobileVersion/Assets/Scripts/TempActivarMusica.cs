using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempActivarMusica : MonoBehaviour {
	public GameObject indicadorActivo;
	public AudioSource fuenteMusica;
	public bool musicaActiva=true;
	// Use this for initialization
	void Start () {
		musicaActiva = true;
	}
	
	// Update is called once per frame
	void Update () {
		Ray rayoM = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitM;
		//Iniciar Juego
		if (Physics.Raycast (rayoM, out hitM)) {
			if(Input.GetMouseButtonDown(0) && hitM.collider.name == "AD_Musica"){
				musicaActiva = !musicaActiva;
			}
		}
		if (musicaActiva) {
			indicadorActivo.SetActive (false);
			fuenteMusica.mute = false;
		} else {
			indicadorActivo.SetActive (true);
			fuenteMusica.mute = true;
		}
	}
}
