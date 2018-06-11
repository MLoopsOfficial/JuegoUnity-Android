using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPrincipalNav : MonoBehaviour {
	public RepositorioSonidos repoSonidos;
	public Sonidos fuenteSonidos;
	public Image[] opciones;
	public int opcionPorDefecto=1;
	private int opcionActual=0;

	void Start () {
		opcionActual = opcionPorDefecto;
		fuenteSonidos = GameObject.Find ("Sonidos").GetComponent<Sonidos>();
		repoSonidos = GameObject.Find ("Sonidos").GetComponent<RepositorioSonidos> ();
	}

	void Update () {
		if (Input.touchCount > 0) {
			if (Input.GetTouch (0).phase == TouchPhase.Ended) {
				fuenteSonidos.fuenteSonido.clip = repoSonidos.navegacion[1];
				fuenteSonidos.fuenteSonido.Play ();
			}
		}
	}
}
