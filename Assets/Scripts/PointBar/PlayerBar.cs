﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBar : MonoBehaviour {

	public Image scoreImage;
	public Image timeImage;


	//private MaxVal maxVal;

	[SerializeField]
	private Stat fruitPoints;

	[SerializeField]
	private Stat timeLeft;

	private float CountDownTimer;
	private float myTimer = 0f;
	private float maxTime = 180f;



	private int currentPoints = 0;

	void Start(){
		GameObject player = GameObject.FindWithTag("Player");
		Collectable collectable = player.GetComponent<Collectable>();
		collectable.scoreValue += 5;
	}

	private void Awake(){
		fruitPoints.Initialize ();
		timeLeft.Initialize ();

	}

	public void FixedUpdate(){
		myTimer += Time.deltaTime;
		timeImage.fillAmount = 1 - (maxTime / myTimer);
	}


	
	// Update is called once per frame
	void Update () {
		if (Collectable.scoreValue > currentPoints) {

			fruitPoints.CurrentVal += 5;
			currentPoints += 5;
			scoreImage.fillAmount = currentPoints / 100;
			//call scoreUpdate() here?

		}
	
	}
}