using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapObj : MonoBehaviour {
	
	public bool tocando=false;
	public string nombreObjeto;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
			Ray rayo = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
			RaycastHit dest;
			if(Physics.Raycast(rayo,out dest)){
				Debug.Log (dest.transform.name);
				if (dest.collider.name == nombreObjeto) {
					tocando = true;
				}
			}
		}
	}
}
