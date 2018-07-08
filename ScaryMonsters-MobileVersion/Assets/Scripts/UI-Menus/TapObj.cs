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
					controladorMenus.menus [1].SetActive(true);
					controladorMenus.menus [0].SetActive (false);
					controladorMenus.menus [7].SetActive(true);
				}
				if(hit.transform.name == "opc_SalirJuego")
				{
					controladorMenus.menus [0].SetActive(true);
					controladorMenus.menus [1].SetActive (false);
					controladorMenus.menus [2].SetActive (false);
					controladorMenus.menus [3].SetActive (false);
					controladorMenus.menus [4].SetActive (false);
					controladorMenus.menus [7].SetActive(true);
				}
				//NuevaPartida
				if(hit.transform.name == "opc_NP")
				{
					controladorMenus.menus [2].SetActive(true);
					controladorMenus.menus [0].SetActive (false);
					controladorMenus.menus [1].SetActive (false);
					controladorMenus.menus [3].SetActive (false);
					controladorMenus.menus [4].SetActive (false);
					controladorMenus.menus [7].SetActive(true);
				}
				//Extras
				if(hit.transform.name == "opc_Extr")
				{
					controladorMenus.menus [4].SetActive(true);
					controladorMenus.menus [0].SetActive (false);
					controladorMenus.menus [1].SetActive (false);
					controladorMenus.menus [2].SetActive (false);
					controladorMenus.menus [3].SetActive (false);
					controladorMenus.menus [7].SetActive(true);
				}
				//Ajustes
				if(hit.transform.name == "opc_AJ")
				{
					controladorMenus.menus [3].SetActive(true);
					controladorMenus.menus [0].SetActive (false);
					controladorMenus.menus [1].SetActive (false);
					controladorMenus.menus [2].SetActive (false);
					controladorMenus.menus [4].SetActive (false);
					controladorMenus.menus [5].SetActive (false);
					controladorMenus.menus [7].SetActive(true);
				}
				//F_BotonHome
				if(hit.transform.name == "botonHome")
				{
					controladorMenus.menus [1].SetActive(true);
					controladorMenus.menus [0].SetActive (false);
					controladorMenus.menus [2].SetActive (false);
					controladorMenus.menus [3].SetActive (false);
					controladorMenus.menus [4].SetActive (false);
					controladorMenus.menus [5].SetActive (false);
					controladorMenus.menus [7].SetActive(true);
				}
				if(hit.transform.name == "botonSettings")
				{
					controladorMenus.menus [0].SetActive (false);
					controladorMenus.menus [1].SetActive (false);
					controladorMenus.menus [2].SetActive (false);
					controladorMenus.menus [3].SetActive (true);
					controladorMenus.menus [4].SetActive (false);
					controladorMenus.menus [7].SetActive(true);
				}
				if(hit.transform.name == "opc_Marcadores")
				{
					controladorMenus.menus [6].SetActive(true);
					controladorMenus.menus [0].SetActive (false);
					controladorMenus.menus [1].SetActive (false);
					controladorMenus.menus [2].SetActive (false);
					controladorMenus.menus [3].SetActive (false);
					controladorMenus.menus [4].SetActive (false);
					controladorMenus.menus [5].SetActive (false);
					controladorMenus.menus [7].SetActive(false);
				}
				if(hit.transform.name == "Cerrar")
				{
					controladorMenus.menus [6].SetActive(false);
					controladorMenus.menus [0].SetActive (false);
					controladorMenus.menus [1].SetActive (true);
					controladorMenus.menus [2].SetActive (false);
					controladorMenus.menus [3].SetActive (false);
					controladorMenus.menus [4].SetActive (false);
					controladorMenus.menus [5].SetActive (false);
					controladorMenus.menus [7].SetActive(true);
				}
				if(hit.transform.name == "opc_Creditos")
				{
					controladorMenus.menus [7].SetActive(true);
					controladorMenus.menus [8].SetActive(true);
					controladorMenus.menus [0].SetActive (false);
					controladorMenus.menus [1].SetActive(false);
					controladorMenus.menus [2].SetActive (false);
					controladorMenus.menus [3].SetActive (false);
					controladorMenus.menus [4].SetActive (false);
					controladorMenus.menus [5].SetActive (false);
				}
			}
		}
	}
}
