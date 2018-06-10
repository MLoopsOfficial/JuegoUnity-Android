using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LerpUIpos : MonoBehaviour {

	public RectTransform elementoUI;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	public Vector3 posInicial;
	public Vector3 posFinal;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
		journeyLength = Vector3.Distance(posInicial, posFinal);
		elementoUI.localPosition = posInicial;
	}

	// Update is called once per frame
	void Update () {
		lerpUIPos ();
	}
	void lerpUIPos()
	{
		movimiento1 ();
	}
	void movimiento1()
	{
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		elementoUI.localPosition = Vector3.Lerp (posInicial, posFinal, fracJourney);
	}
}
