using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControladorPaisRegBandera : MonoBehaviour {
	public Sonidos snds;
	public Dropdown listaPaises;

	public Image contenedorGrafico;

	public Sprite banderaMexico;
	public Sprite banderaUE;
	public Sprite banderaUSA;
	public Sprite banderaUK;
	public Sprite banderaJP;
	public Sprite banderaBR;
	public Sprite banderaAR;
	public Sprite banderaPR;
	public Sprite banderaCA;
	public Sprite banderaCH;
	public Sprite banderaCO;
	public Sprite banderaCHA;
	public Sprite banderaRU;

	public Sprite banderaDEFAULT;

	public string pais="";
	// Use this for initialization
	void Start (){

	}
	
	// Update is called once per frame
	void Update () {
		
		if (listaPaises.value == 0) {
			contenedorGrafico.sprite = banderaMexico;
			pais = "Mexico";
		} else if (listaPaises.value == 1) {
			contenedorGrafico.sprite = banderaUE;
			pais = "European Union";
		} else if (listaPaises.value == 2) {
			contenedorGrafico.sprite = banderaUSA;
			pais = "United States";
		} 
		else if (listaPaises.value == 3) {
			contenedorGrafico.sprite = banderaUK;
			pais = "United Kingdom";
		} 
		else if (listaPaises.value == 4) {
			contenedorGrafico.sprite = banderaJP;
			pais = "Japan";
		} 
		else if (listaPaises.value == 5) {
			contenedorGrafico.sprite = banderaBR;
			pais = "Brasil";
		} 
		else if (listaPaises.value == 6) {
			contenedorGrafico.sprite = banderaAR;
			pais = "Argentina";
		}
		else if (listaPaises.value == 7) {
			contenedorGrafico.sprite = banderaPR;
			pais = "Peru";
		}
		else if (listaPaises.value == 8) {
			contenedorGrafico.sprite = banderaCA;
			pais = "Canada";
		}
		else if (listaPaises.value == 9) {
			contenedorGrafico.sprite = banderaCH;
			pais = "Chile";
		}
		//
		else if (listaPaises.value == 10) {
			contenedorGrafico.sprite = banderaCO;
			pais = "Colombia";
		}
		else if (listaPaises.value == 11) {
			contenedorGrafico.sprite = banderaCHA;
			pais = "China";
		}
		else if (listaPaises.value == 12) {
			contenedorGrafico.sprite = banderaRU;
			pais = "Russia";
		}else {
			contenedorGrafico.sprite = banderaDEFAULT;
			pais = "Otro";
		}
	}
}
