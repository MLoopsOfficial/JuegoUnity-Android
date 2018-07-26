using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumenMusica : MonoBehaviour {
	public Musica musica;
	public Scrollbar controladorVol;

	// Use this for initialization
	void Start () {
		musica = GameObject.Find ("Musica").GetComponent<Musica> ();
		controladorVol = GetComponent<Scrollbar> ();
	}
	
	// Update is called once per frame
	void Update () {
		musica.fuenteMusica.volume = controladorVol.value;
	}
}
