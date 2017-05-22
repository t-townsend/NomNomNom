using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {
	public int scoreValue;
	private PlayerController playerController;

	// Use this for initialization
	void Start () {
		

		GameObject playerControllerObject = GameObject.FindWithTag ("PlayerController");
		if (playerControllerObject != null) {
			playerController = playerControllerObject.GetComponent<PlayerController>();
		}
		if (playerController == null) {
			Debug.Log ("Cannot find 'PlayerController' script");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D target) {
		if (target.gameObject.tag == "Player") {
			Destroy (gameObject);
			playerController.AddScore (scoreValue);
		

		}
	}
}
