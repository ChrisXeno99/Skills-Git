using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoAnimation : MonoBehaviour {

	Animator MyAnimator;

	void Start () {
		MyAnimator = GetComponent<Animator> ();
	}

	void Update () {
		if (Input.GetKey (KeyCode.RightArrow))
		{
			MyAnimator.SetBool ("walk", true);
		}
		else
		{
			MyAnimator.SetBool ("walk", false);
		}
			
}
}
