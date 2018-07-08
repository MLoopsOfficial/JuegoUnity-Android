using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMenus : MonoBehaviour {
	
	public RepositorioSonidos repoSonidos;
	public Sonidos fuenteSonidos;
	public GameObject[] menus;
	public bool evento=false;
	// Use this for initialization
	void Start () {
		fuenteSonidos = GameObject.Find ("Sonidos").GetComponent<Sonidos>();
		repoSonidos = GameObject.Find ("Sonidos").GetComponent<RepositorioSonidos> ();
	}
	
	// Update is called once per frame
	void Update () {
		eventoClickTap ();
		if (evento) {
			fuenteSonidos.fuenteSonido.clip = repoSonidos.navegacion[0];
			fuenteSonidos.fuenteSonido.Play ();
		}
	}

	void eventoClickTap()
	{
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				evento = true;
			}
		} else {
			evento = false;
		}
	}
}
