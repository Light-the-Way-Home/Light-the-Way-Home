using UnityEngine;
using System.Collections;

public class PickUpObject : MonoBehaviour
{
	Animator anim;
	public Light PlayerLight;
	public bool isDimming;
	public float maxIntensity;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			StartCoroutine ("wait");
			if (isDimming) {
				PlayerLight.intensity = maxIntensity;
			}
		}
	}

	IEnumerator wait(){
		anim.SetBool ("Shatter", true);
		yield return new WaitForSeconds (1f);
		Destroy (gameObject);
	}
}