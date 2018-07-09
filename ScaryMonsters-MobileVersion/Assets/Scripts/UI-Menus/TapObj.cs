using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapObj : MonoBehaviour {
	public RepositorioSonidos repoSonidos;
	public Sonidos fuenteSonidos;
	public ControladorMenus controladorMenus;
	public Transform obj;
	public GameObject efectoPulso;
	// Use this for initialization
	void Start () {
		obj = gameObject.GetComponent<Transform> ();
		fuenteSonidos = GameObject.Find ("Sonidos").GetComponent<Sonidos>();
		repoSonidos = GameObject.Find ("Sonidos").GetComponent<RepositorioSonidos> ();
	}
	
	// Update is called once per frame
	void Update () {
		onClickObj ();
	}
	void onClickObj()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				fuenteSonidos.fuenteSonido.clip = repoSonidos.navegacion[0];
				fuenteSonidos.fuenteSonido.Play ();
				if(hit.transform.name == "InicioJuego")
				{
					
				}
				if(hit.transform.name == "opc_SalirJuego")
				{
					
				}
				//NuevaPartida
				if(hit.transform.name == "opc_NP")
				{
					
				}
				//Extras
				if(hit.transform.name == "opc_Extr")
				{
					
				}
				//Ajustes
				if(hit.transform.name == "opc_AJ")
				{
					
				}
				//F_BotonHome
				if(hit.transform.name == "botonHome")
				{
					
				}
				if(hit.transform.name == "botonSettings")
				{
					
				}
				if(hit.transform.name == "opc_Marcadores")
				{
					
				}
				if(hit.transform.name == "Cerrar")
				{
					
				}
				if(hit.transform.name == "opc_Creditos")
				{
					
				}
			}
		}
	}
}
