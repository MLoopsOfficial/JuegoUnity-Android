using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaRebotadora : MonoBehaviour {

	public float velocidadInicial=600f;
	public Rigidbody rbPelota;
	public Transform barra;
	public bool enJuego;
	Vector3 posInicial;


	// Use this for initialization
	void Start () {
		posInicial = transform.position;
	}
	public void Reset()
	{
		transform.position = posInicial;
		transform.SetParent (barra);
		enJuego = false;
		detenerMov ();
	}
	public void detenerMov()
	{
		rbPelota.isKinematic = true;
		rbPelota.velocity = Vector3.zero;
	}
	// Update is called once per frame

	void Update () {
		if (!enJuego && Input.GetButtonDown ("Fire1")) {
			enJuego = true;
			transform.SetParent (null);
			rbPelota.isKinematic = false;
			rbPelota.AddForce (new Vector3 (0, velocidadInicial, 0));
		}
	}
}
