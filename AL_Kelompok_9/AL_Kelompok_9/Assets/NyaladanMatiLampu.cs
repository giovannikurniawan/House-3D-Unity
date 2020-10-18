// ToggleLight.cs
// Turns the light component of this object on/off when the user presses and releases the `L` key.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyaladanMatiLampu : MonoBehaviour {

	Light light;

	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
	}

	// Update is called once per frame
	void Update () {
		// Toggle light on/off when L key is pressed.
		if (Input.GetKeyUp (KeyCode.L)) {
			light.enabled = !light.enabled;
		}
	}
}