using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InternetConnectionChecker : MonoBehaviour {
	public bool hayInternet;
	public Text textoMensaje;
	public string mensajeAlerta;
	public Image iconoInternet;
	public Image sinConexImg;
	public Image alertaConexImg;

	void Start () {
		hayInternet = true;
		iconoInternet.enabled = false;
		sinConexImg.enabled = false;
		alertaConexImg.enabled = false;
	}

	void Update () {
		if(Application.internetReachability != NetworkReachability.NotReachable)
		{
			textoMensaje.text = " ";
			hayInternet = true;
			iconoInternet.enabled = false;
			sinConexImg.enabled = false;
			alertaConexImg.enabled = false;
		}else{
			hayInternet = false;
			iconoInternet.enabled = true;
			sinConexImg.enabled = true;
			textoMensaje.text = mensajeAlerta;
			Debug.LogWarning (mensajeAlerta);
		}
	}
}
