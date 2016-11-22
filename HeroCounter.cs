using UnityEngine;
using System.Collections;

public class HeroCounter : MonoBehaviour
{
	public Light PlayerLight;
	public bool isDimming;

	// Use this for initialization
	void Start ()
	{
	}

	// Update is called once per frame
	void Update ()
	{
		if (isDimming) {
			//PlayerLight.intensity = PlayerLight.intensity * (1 - Time.deltaTime);
			PlayerLight.intensity -= Time.deltaTime;
			if (PlayerLight.intensity <= 0) {
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
}