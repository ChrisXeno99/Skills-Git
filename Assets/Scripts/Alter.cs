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
			Debug.Log("Won game");
			SceneManager.LoadScene ("Won");
		}
	}
}
//public void OnCollisionEnter2D(Collision2D other){

	//if (other.gameObject.tag == "extraLife") {
		//lives += 1;
		//Destroy (other.gameObject);
	//} else if (other.gameObject.tag == "vulnerable") {
	//	Destroy (other.gameObject);
	//	vulnerable = true;
	//	Debug.Log ("vulnerable = true!");
	//	StartCoroutine("VulnerableDebuff");
	//}
//}