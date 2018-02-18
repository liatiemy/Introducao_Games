using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {
	
	public float ballForce;
	public GameObject explosaoPrefab;

	void Start () {
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (ballForce, ballForce));
		print (ballForce);
	}
		
	void Update(){
		print (ballForce);
	}

	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "Bloco") {
			Instantiate (explosaoPrefab, transform.position, transform.rotation);
			PrincipalScript.pontos++;
			Destroy (c.gameObject);
			if (PrincipalScript.pontos == 9) {
				SceneManager.LoadScene ("Start");
			}
		}
		if (c.gameObject.tag == "Chao") {
			PrincipalScript.vidas--;
			if (PrincipalScript.vidas <= 0) {
				SceneManager.LoadScene ("Start");				
			} else {
				GetComponent<Rigidbody2D> ().position = new Vector2 (0.0f, 0.0f);
			}
		}
	}
}
