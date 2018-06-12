using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Contador : MonoBehaviour {
	public Text textoTiempo;
	public float tiemposRestante;
	public AudioSource musicaNivel;
	// Use this for initialization
	void Start () {
		textoTiempo = GetComponent<Text> ();
		musicaNivel = GameObject.FindWithTag ("MainCamera").GetComponent<AudioSource> ();
		musicaNivel.pitch = 1.0f;
	}

	// Update is called once per frame
	void Update () {
		contadorRegresivo ();
		checarFinPartida ();
		ChecarPitcheoMusica ();
		if (tiemposRestante <= 10) {
			textoTiempo.color = Color.red;
			textoTiempo.fontStyle = FontStyle.Bold;
		}
	}
	void contadorRegresivo()
	{
		tiemposRestante -= Time.deltaTime;
		if(tiemposRestante < 0)
		{
			tiemposRestante = 0;
		}
		textoTiempo.text = ":" + Mathf.Round (tiemposRestante).ToString();
	}
	void checarFinPartida()
	{
		if (tiemposRestante == 0) {
			Time.timeScale = 0;
		}
	}
	void ChecarPitcheoMusica()
	{
		if(tiemposRestante >= 50 && tiemposRestante <= 100)
		{
			musicaNivel.pitch = 1.03f;
		}else if(tiemposRestante >= 20 && tiemposRestante <= 49){
			musicaNivel.pitch = 1.06f;
		}else if(tiemposRestante >= 10 && tiemposRestante <= 19){
			musicaNivel.pitch = 1.09f;
		}
		if(tiemposRestante == 0)
		{
			musicaNivel.volume -= 0.005f;
		}
	}
	void cambiarNivel()
	{

	}
}
