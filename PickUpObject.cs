using UnityEngine;
using System.Collections;

public class PickUpObject : MonoBehaviour
{

	public Light PlayerLight;
	public bool isDimming;
	public float maxIntensity;

	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
			if (isDimming) {
				PlayerLight.intensity = maxIntensity;
			}
		}
	}
}