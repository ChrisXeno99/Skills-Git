﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 10);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDestroy(){
		Debug.Log("A bomb was destroyed");
	}
}
