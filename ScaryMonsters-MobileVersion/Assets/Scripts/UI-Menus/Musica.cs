using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour {

	public AudioSource fuenteMusica;
	// Use this for initialization
	void Start () {
		fuenteMusica = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
