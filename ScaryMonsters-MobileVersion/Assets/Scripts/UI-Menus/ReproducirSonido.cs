using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproducirSonido : MonoBehaviour {
	public AudioSource fuenteSonidos;
	public AudioClip sonido;
	public float volumen;
	// Use this for initialization
	void Start () {
		fuenteSonidos = GameObject.Find ("Sonidos").GetComponent<AudioSource>();
		f_ReproduceSonido ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void f_ReproduceSonido()
	{
		fuenteSonidos.clip = sonido;
		fuenteSonidos.PlayOneShot (sonido, volumen);
	}
}
