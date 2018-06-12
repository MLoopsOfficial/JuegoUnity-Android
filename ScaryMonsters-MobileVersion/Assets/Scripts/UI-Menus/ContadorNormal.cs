using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ContadorNormal : MonoBehaviour {
	public Text textoTiempo;
	public float tiemposTranscurrido;
	// Use this for initialization
	void Start () {
		textoTiempo = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		contadorNormal ();
	}
	void contadorNormal()
	{
		tiemposTranscurrido += Time.deltaTime;
		if(tiemposTranscurrido < 0)
		{
			tiemposTranscurrido = 0;
		}
		textoTiempo.text = ":" + Mathf.Round (tiemposTranscurrido).ToString();
	}
}
