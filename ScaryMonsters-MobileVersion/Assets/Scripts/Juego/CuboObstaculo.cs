using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboObstaculo : MonoBehaviour {

	public bool cuboComplejo=true;
	public GameObject cuboE;
	public GameObject[] estados;
	public int vidaMax = 3;
	public int vidaActual;


	// Use this for initialization
	void Start () {
		vidaActual = vidaMax;
	}
	
	// Update is called once per frame
	void Update () {
		if (vidaActual > 0) {
			cuboE.SetActive (true);
		}
		if (cuboComplejo) {
			f_cuboComplejo ();
		} else {
			cuboSimple ();
		}
	}
	void f_cuboComplejo(){
		vidaMax = 3;
		f_activarEstados ();
	}
	void cuboSimple(){
		vidaMax = 1;
		estados [0].SetActive (true);
	}
	void f_activarEstados()
	{
		if(cuboComplejo && vidaActual == 3)
		{
			estados [0].SetActive (false);
			estados [1].SetActive (true);
			estados [2].SetActive (false);
			estados [3].SetActive (false);
		}else if(cuboComplejo && vidaActual == 2)
		{
			estados [0].SetActive (false);
			estados [1].SetActive (false);
			estados [2].SetActive (true);
			estados [3].SetActive (false);
		}else if(cuboComplejo && vidaActual == 1)
		{
			estados [0].SetActive (false);
			estados [1].SetActive (false);
			estados [2].SetActive (false);
			estados [3].SetActive (true);
		}else if(vidaActual <= 0)
		{
			estados [0].SetActive (false);
			estados [1].SetActive (false);
			estados [2].SetActive (false);
			estados [3].SetActive (false);
			cuboE.SetActive (false);
		}
	}
}
