using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
