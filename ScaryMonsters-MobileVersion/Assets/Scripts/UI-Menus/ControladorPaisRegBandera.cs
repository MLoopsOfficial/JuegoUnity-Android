﻿using System.Collections;
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
	// Use this for initialization
	void Start (){

	}
	
	// Update is called once per frame
	void Update () {
		
		if (listaPaises.value == 0) {
			contenedorGrafico.sprite = banderaMexico;
		} else if (listaPaises.value == 1) {
			contenedorGrafico.sprite = banderaUE;	
		} else if (listaPaises.value == 2) {
			contenedorGrafico.sprite = banderaUSA;
		} 
		else if (listaPaises.value == 3) {
			contenedorGrafico.sprite = banderaUK;
		} 
		else if (listaPaises.value == 4) {
			contenedorGrafico.sprite = banderaJP;
		} 
		else if (listaPaises.value == 5) {
			contenedorGrafico.sprite = banderaBR;
		} 
		else if (listaPaises.value == 6) {
			contenedorGrafico.sprite = banderaAR;
		}
		else if (listaPaises.value == 7) {
			contenedorGrafico.sprite = banderaPR;
		}
		else if (listaPaises.value == 8) {
			contenedorGrafico.sprite = banderaCA;
		}
		else if (listaPaises.value == 9) {
			contenedorGrafico.sprite = banderaCH;
		}
		//
		else if (listaPaises.value == 10) {
			contenedorGrafico.sprite = banderaCO;
		}
		else if (listaPaises.value == 11) {
			contenedorGrafico.sprite = banderaCHA;
		}
		else if (listaPaises.value == 12) {
			contenedorGrafico.sprite = banderaRU;
		}else {
			contenedorGrafico.sprite = banderaDEFAULT;
		}
	}
}
