using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaLerp : MonoBehaviour {
	public Image sprite;
	public float tiempoLerp=0.0f;
	public int valorAlphaI = 255;
	public int valorAlphaF = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Color alphaAmount = sprite.GetComponent<Image> ().color;
		alphaAmount.a = Mathf.Lerp(valorAlphaI, valorAlphaF, tiempoLerp);
		Debug.Log (alphaAmount.a);
		// .. and increate the t interpolater
		tiempoLerp += 0.5f * Time.deltaTime;

		// now check if the interpolator has reached 1.0
		// and swap maximum and minimum so game object moves
		// in the opposite direction.
		if (tiempoLerp > 1.0f)
		{
			int temp = valorAlphaI;
			valorAlphaF = valorAlphaI;
			valorAlphaI = temp;
			tiempoLerp = 0.0f;
		}
	}
}
