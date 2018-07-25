using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notificacion : MonoBehaviour {

	[Header("Strings")]
	public string header = "";
	public string cuerpo = "";
	public string contadorConv;
	public int contadorNotifi=1;
	[Header("UI Elements")]
	public Text contenedorHeader;
	public Text contenedorCuerpo;
	public Text contenedorCantNotif;
	[Header("Sonidos")]
	public AudioSource fuenteSonidos;
	public AudioClip sonidoO;
	public AudioClip sonidoC;
	[Header("Animacion")]
	public Animator animador;
	[Header("Estados")]
	public bool abierta = false;
	public bool cerrada = false;

	// Use this for initialization
	void Start () {
		contenedorHeader.text = header;
		contenedorCuerpo.text = cuerpo;
		fuenteSonidos = GameObject.Find ("Sonidos").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		contadorConv = contadorNotifi.ToString ();
		contenedorCantNotif.text = contadorConv;
		if (contadorNotifi <= 0) {
			contadorNotifi = 0;
		}
	}
	public void mostrarNotificacion()
	{
		abierta = true;
		animador.SetBool ("open", true);
		animador.SetBool ("close", false);
		sonidoShow ();
	}
	public void cerrarNotificacion()
	{
		cerrada = true;
		animador.SetBool ("close", true);
		animador.SetBool ("open", false);
		contadorNotifi--;
		sonidoClose ();
	}
	public void sonidoShow()
	{
		fuenteSonidos.clip = sonidoO;
		fuenteSonidos.PlayOneShot (sonidoO, 0.5f);
	}
	public void sonidoClose()
	{
		fuenteSonidos.clip = sonidoC;
		fuenteSonidos.PlayOneShot (sonidoC, 0.5f);
	}
}
