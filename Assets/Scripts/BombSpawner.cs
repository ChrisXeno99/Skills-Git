﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour {
	public GameObject bomb;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawner", 2, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void  Spawner(){
		Instantiate (bomb, new Vector3 (8.42f, 7.64f, 0), Quaternion.identity);
	}
}
