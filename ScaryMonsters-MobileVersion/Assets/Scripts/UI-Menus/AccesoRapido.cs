using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesoRapido : MonoBehaviour {

	public GameObject botonHome;
	public GameObject botonOpc;
	public GameObject botonShop;
	public GameObject botonNotificaciones;

	public bool homeActivo=true;
	public bool opcActivo=true;
	public bool shopActivo=true;
	public bool botonNotif=true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Boton Home
		if (homeActivo == true) {
			botonHome.SetActive (true);
		} else {
			botonHome.SetActive (false);
		}
		//Boton Opciones
		if (opcActivo == true) {
			botonOpc.SetActive (true);
		} else {
			botonOpc.SetActive (false);
		}
		//Boton Tienda
		if (shopActivo == true) {
			botonShop.SetActive (true);
		} else {
			botonShop.SetActive (false);
		}
		//Boton Notificacion
		if (botonNotif == true) {
			botonNotificaciones.SetActive (true);
		} else {
			botonNotificaciones.SetActive (false);
		}
	}
}
