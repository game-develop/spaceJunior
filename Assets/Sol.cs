using UnityEngine;
using System.Collections;

public class Sol : MonoBehaviour {

	GameObject sol;

	void Start () {
		GameObject[] planets = GameObject.FindGameObjectsWithTag ("Planet");
		sol = planets[0];
		foreach (GameObject planet in planets) {
			if (planet.rigidbody.mass > sol.rigidbody.mass) sol = planet;
		}
	}
	// Update is called once per frame
	void Update () {
		this.transform.position = sol.transform.position;
	}
}
