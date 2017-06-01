using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWindow : GenericWindow {

	public override void Open(){
	}

	public void BlorpPurple(){
		manager.Open (1);
	}
	public void GrogGreen(){
		Debug.Log ("Grog pressed");
	}


}
