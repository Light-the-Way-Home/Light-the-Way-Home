using UnityEngine;
using System.Collections;

public class CrystalLight : MonoBehaviour {

	public Light crystalLight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		crystalLight.intensity = 5;
	}
}
