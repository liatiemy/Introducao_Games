using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour {


	public float intervalo;

	void Start () {
		Destroy (gameObject, intervalo);
	}
}
