using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMenus : MonoBehaviour {

	public MenuPrincipalNav s_MenuPrincipal;
	public GameObject[] menus;
	// Use this for initialization
	void Start () {
		menus [0].SetActive (true);
		menus [1].SetActive (false);
		menus [2].SetActive (false);
		menus [3].SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
