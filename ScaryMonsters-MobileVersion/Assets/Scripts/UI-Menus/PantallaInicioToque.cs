using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaInicioToque : MonoBehaviour {
	public RepositorioSonidos repoSonidos;
	public Sonidos fuenteSonidos;
	public GameObject pantallaInicio;
	// Use this for initialization
	void Start () {
		fuenteSonidos = GameObject.Find ("Sonidos").GetComponent<Sonidos>();
		repoSonidos = GameObject.Find ("Sonidos").GetComponent<RepositorioSonidos> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if(Input.GetTouch(0).phase == TouchPhase.Ended){
				Debug.Log ("Juego Iniciado...");
				fuenteSonidos.fuenteSonido.clip = repoSonidos.navegacion[0];
				fuenteSonidos.fuenteSonido.Play ();
				pantallaInicio.SetActive (false);
			}
		}
	}
	void temporalUage(){
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
