using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Alter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnCollisionEnter2D(Collision2D other)
	{

		if (other.gameObject.tag == "Player") 
		{
			if (SceneManager.GetActiveScene().name == "Levels Tutorial") 
			{
				Debug.Log ("Won level");
				SceneManager.LoadScene ("Level2");
			} else 
			{
				Debug.Log ("Won game");
				SceneManager.LoadScene ("Won");
			}
		}
	}
}
