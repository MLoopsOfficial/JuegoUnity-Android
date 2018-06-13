using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	public int valorItem=0;
	public int multiplicadorPuntos = 0;
	public bool rotarItem = true;
	public bool oscilarItem = true;
	private RotarObjeto scriptRotacion;
	private Oscilar scriptOscilar;
	// Use this for initialization
	void Start () {
		scriptRotacion = GetComponent<RotarObjeto> ();
		scriptOscilar = GetComponent<Oscilar> ();
		multiplicadorPuntos = valorItem * 10;
		checarOsc ();
		checarRot ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void checarRot()
	{
		if (rotarItem) {
			scriptRotacion.enabled = true;
		} else {
			scriptRotacion.enabled = false;
		}
	}
	void checarOsc()
	{
		if (oscilarItem) {
			scriptOscilar.enabled = true;
		} else {
			scriptOscilar.enabled = false;
		}
	}
}
