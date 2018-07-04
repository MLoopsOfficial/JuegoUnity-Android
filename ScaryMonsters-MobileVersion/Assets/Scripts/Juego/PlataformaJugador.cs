using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaJugador : MonoBehaviour {

	public float velocidad = 0.4f;
	public int limiteIzq;
	public int limiteDer;
	Vector3 posicionInicial;

	// Use this for initialization
	void Start () {
		posicionInicial = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float tecladoHor = Input.GetAxisRaw("Horizontal");
		float posX = transform.position.x +(tecladoHor * velocidad * Time.deltaTime);
		transform.position = new Vector3 (Mathf.Clamp (posX, limiteIzq, limiteDer), transform.position.y, transform.position.z);
	}
}
