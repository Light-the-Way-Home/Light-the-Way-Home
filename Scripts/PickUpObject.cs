using UnityEngine;
using System.Collections;

public class PickUpObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject obj = GameObject.Find("PlayerLight");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player"))
			Destroy(gameObject);
	}
}