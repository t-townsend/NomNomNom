using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Vector2 moving = new Vector2 ();

	[SerializeField]
	private Text scoreText;

	private int score;


	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
	}
	
	// Update is called once per frame
	void Update () {
	
		moving.x = moving.y = 0;

		if (Input.GetKey ("right")) {
			moving.x = 1;
		} else if (Input.GetKey ("left")) {
			moving.x = -1;
		}

		if (Input.GetKey ("up")) {
			moving.y = 1;
		} else if (Input.GetKey ("down")) {
			moving.y = -1;
		}
	}

	public void AddScore(int newScoreValue){
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore (){
		scoreText.text = "Fruit Points: " + score;
	}
}
