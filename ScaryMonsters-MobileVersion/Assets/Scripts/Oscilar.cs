using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilar : MonoBehaviour {

	private Vector3 _startPosition;
	public float multiplicador;
	public float multiplicadorAmplitud;

	// Use this for initialization
	void Start () {
		_startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = _startPosition + new Vector3(0.0f, (Mathf.Sin(Time.time*multiplicador))*multiplicadorAmplitud, 0.0f);
	}
}
