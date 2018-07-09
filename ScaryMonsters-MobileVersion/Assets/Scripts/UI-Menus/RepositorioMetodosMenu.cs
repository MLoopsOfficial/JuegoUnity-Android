using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositorioMetodosMenu : MonoBehaviour {
	[Header ("Musica")]
	public RepositorioMusica repoMusica;
	public Musica fuenteMusica;
	[Header ("Sonidos")]
	public RepositorioSonidos repoSonidos;
	public Sonidos fuenteSonidos;
	[Header ("Pantallas")]
	public GameObject pantallaInicio;
	public GameObject accesoRapido;
	public GameObject menuPrincipal;
	public GameObject menuAjustes;
	public GameObject submenuSonido;
	public GameObject menuExtras;
	public GameObject nuevoRegistro;
	public GameObject creditos;
	public GameObject tienda;
	public GameObject marcadores;

	bool creditosBool = false;


	void Start()
	{
		fuenteSonidos = GameObject.Find ("Sonidos").GetComponent<Sonidos>();
		repoSonidos = GameObject.Find ("Sonidos").GetComponent<RepositorioSonidos> ();
		repoMusica = GameObject.Find ("Musica").GetComponent<RepositorioMusica> ();
		fuenteMusica = GameObject.Find ("Musica").GetComponent<Musica> ();

		fuenteMusica.fuenteMusica.clip = repoMusica.musicaMenus [0];
		fuenteMusica.fuenteMusica.Play ();
		accesoRapido.SetActive (true);
	}
		
	public void Sonido()
	{
		fuenteSonidos.fuenteSonido.clip = repoSonidos.navegacion[0];
		fuenteSonidos.fuenteSonido.Play ();
	}

	public void pantallaInicioActiva()
	{
		menuPrincipal.SetActive (false);
		accesoRapido.SetActive (false);
		pantallaInicio.SetActive (true);
		menuAjustes.SetActive (false);
		submenuSonido.SetActive (false);
		menuExtras.SetActive (false);
		nuevoRegistro.SetActive (false);
		tienda.SetActive (false);
		marcadores.SetActive (false);
		creditos.SetActive (false);
	}

	public void menuPrincipalActivo()
	{
		//Musica
		if(fuenteMusica.fuenteMusica.clip == repoMusica.musicaMenus[1]){
		fuenteMusica.fuenteMusica.Stop ();
		fuenteMusica.fuenteMusica.clip = repoMusica.musicaMenus [0];
		fuenteMusica.fuenteMusica.Play ();
		//
		}

		menuPrincipal.SetActive (true);
		accesoRapido.SetActive (true);
		pantallaInicio.SetActive (false);
		menuAjustes.SetActive (false);
		submenuSonido.SetActive (false);
		menuExtras.SetActive (false);
		nuevoRegistro.SetActive (false);
		tienda.SetActive (false);
		marcadores.SetActive (false);
		creditos.SetActive (false);
	}
	public void menuAjustesActivo()
	{
		menuAjustes.SetActive (true);
		accesoRapido.SetActive (true);
		menuPrincipal.SetActive (false);
		pantallaInicio.SetActive (false);
		submenuSonido.SetActive (false);
		menuExtras.SetActive (false);
		nuevoRegistro.SetActive (false);
		tienda.SetActive (false);
		marcadores.SetActive (false);
		creditos.SetActive (false);
	}
	public void nuevaPartidaActivo()
	{
		accesoRapido.SetActive (true);
		nuevoRegistro.SetActive (true);
		menuAjustes.SetActive (false);
		menuPrincipal.SetActive (false);
		pantallaInicio.SetActive (false);
		submenuSonido.SetActive (false);
		menuExtras.SetActive (false);
		tienda.SetActive (false);
		marcadores.SetActive (false);
		creditos.SetActive (false);
	}
	public void menuExtrasActivo()
	{
		accesoRapido.SetActive (true);
		nuevoRegistro.SetActive (false);
		menuAjustes.SetActive (false);
		menuPrincipal.SetActive (false);
		pantallaInicio.SetActive (false);
		submenuSonido.SetActive (false);
		menuExtras.SetActive (true);
		tienda.SetActive (false);
		marcadores.SetActive (false);
		creditos.SetActive (false);
	}
	public void tiendaActiva()
	{
		accesoRapido.SetActive (true);
		nuevoRegistro.SetActive (false);
		menuAjustes.SetActive (false);
		menuPrincipal.SetActive (false);
		pantallaInicio.SetActive (false);
		submenuSonido.SetActive (false);
		menuExtras.SetActive (false);
		tienda.SetActive (true);
		marcadores.SetActive (false);
		creditos.SetActive (false);
	}
	public void marcadoresActivo()
	{
		accesoRapido.SetActive (false);
		nuevoRegistro.SetActive (false);
		menuAjustes.SetActive (false);
		menuPrincipal.SetActive (false);
		pantallaInicio.SetActive (false);
		submenuSonido.SetActive (false);
		menuExtras.SetActive (false);
		tienda.SetActive (false);
		marcadores.SetActive (true);
		creditos.SetActive (false);
	}
	public void creditosActivo()
	{
		//Musica
		fuenteMusica.fuenteMusica.Stop ();
		fuenteMusica.fuenteMusica.clip = repoMusica.musicaMenus [1];
		fuenteMusica.fuenteMusica.Play ();
		//
		accesoRapido.SetActive (false);
		nuevoRegistro.SetActive (false);
		menuAjustes.SetActive (false);
		menuPrincipal.SetActive (false);
		pantallaInicio.SetActive (false);
		submenuSonido.SetActive (false);
		menuExtras.SetActive (false);
		tienda.SetActive (false);
		marcadores.SetActive (false);
		creditos.SetActive (true);
	}
}
