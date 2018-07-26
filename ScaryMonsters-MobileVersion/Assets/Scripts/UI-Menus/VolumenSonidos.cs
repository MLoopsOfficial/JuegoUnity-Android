using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VolumenSonidos : MonoBehaviour {
	public Sonidos sonidos;
	public Scrollbar controladorSond;
	// Use this for initialization
	void Start () {
		sonidos = GameObject.Find ("Sonidos").GetComponent<Sonidos> ();
		controladorSond = GetComponent<Scrollbar> ();
	}
	
	// Update is called once per frame
	void Update () {
		sonidos.fuenteSonido.volume = controladorSond.value;
	}
}
