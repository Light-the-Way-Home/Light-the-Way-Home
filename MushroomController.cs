using UnityEngine;
using System.Collections;

public class MushroomController : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update () {
		//anim.SetBool ("bounceIsFalse", true);
	}

	void OnCollisionEnter2D (Collision2D other){

		StartCoroutine ("wait");

	}

	IEnumerator wait(){
		anim.SetBool ("bounceIsTrue", true);
		yield return new WaitForSeconds (1f);
		anim.SetBool ("bounceIsTrue", false);
	}
}
