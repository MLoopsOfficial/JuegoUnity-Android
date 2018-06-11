using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour {
	public RepositorioSonidos repoSonidos;
	public AudioSource fuenteSonido;
	// Use this for initialization
	void Start () {
		fuenteSonido = GetComponent<AudioSource> ();
		repoSonidos = GetComponent<RepositorioSonidos> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
