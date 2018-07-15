using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMenus : MonoBehaviour {
	private RepositorioMetodosMenu repoMenu;

	void Start()
	{
		repoMenu = GameObject.Find ("Canvas").GetComponent<RepositorioMetodosMenu> ();
		repoMenu.pantallaInicioActiva ();
	}
	//Update
	void Update () {
		eventoClickTap ();
	}


	//Activador/Desactivador
	void eventoClickTap()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		//Iniciar Juego
		if (Physics.Raycast (ray, out hit)) {
			if(Input.GetMouseButtonDown(0) && hit.collider.name == "InicioJuego"){
				repoMenu.menuPrincipalActivo ();
				repoMenu.Sonido ();
			}
		}
		//Boton Home
		if (Physics.Raycast (ray, out hit)) {
			if(Input.GetMouseButtonDown(0) && (hit.collider.name == "botonHome"|| hit.collider.name == "Cerrar")){
				repoMenu.menuPrincipalActivo ();
				repoMenu.Sonido ();
			}
		}
		//Menu Principal
		if (Physics.Raycast (ray, out hit)) {
			if(Input.GetMouseButtonDown(0) && hit.collider.name == "Opc_NP"){
				repoMenu.nuevaPartidaActivo ();
				repoMenu.Sonido ();
			}
		}
		//Menu Ajustes
		if (Physics.Raycast (ray, out hit)) {
			if(Input.GetMouseButtonDown(0) && (hit.collider.name == "Opc_AJ" || hit.collider.name == "botonSettings")){
				repoMenu.menuAjustesActivo ();
				repoMenu.Sonido ();
			}
		}
		//Menu Extras
		if (Physics.Raycast (ray, out hit)) {
			if(Input.GetMouseButtonDown(0) && hit.collider.name == "Opc_Extr"){
				repoMenu.menuExtrasActivo ();
				repoMenu.Sonido ();
			}
		}
		//Menu Salir
		if (Physics.Raycast (ray, out hit)) {
			if(Input.GetMouseButtonDown(0) && hit.collider.name == "Opc_SalirJuego"){
				repoMenu.pantallaInicioActiva ();
				repoMenu.Sonido ();
			}
		}
		//Menu Tienda
		if (Physics.Raycast (ray, out hit)) {
			if(Input.GetMouseButtonDown(0) && (hit.collider.name == "botonTienda" || hit.collider.name == "Opc_Shop")){
				repoMenu.tiendaActiva ();
				repoMenu.Sonido ();
			}
		}
		//Marcadores
		if (Physics.Raycast (ray, out hit)) {
			if(Input.GetMouseButtonDown(0) && hit.collider.name == "Opc_Marcadores"){
				repoMenu.marcadoresActivo ();
				repoMenu.Sonido ();
			}
		}
		//Creditos
		if (Physics.Raycast (ray, out hit)) {
			if(Input.GetMouseButtonDown(0) && hit.collider.name == "Opc_Creditos"){
				repoMenu.creditosActivo ();
				repoMenu.Sonido ();
			}
		}
		//SubMenu Ajustes
		if (Physics.Raycast (ray, out hit)) {
			if(Input.GetMouseButtonDown(0) && hit.collider.name == "opc_SND"){
				repoMenu.subMenuAjustesActivo ();
				repoMenu.Sonido ();
			}
		}
	}
}