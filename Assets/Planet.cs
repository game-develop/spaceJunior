using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

		public Vector3 nullForce;
		public Vector3 nullRotation;

	// Use this for initialization
	void Start () {
		rigidbody.collider.material.dynamicFriction = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {
				transform.rigidbody.MoveRotation (transform.rigidbody.rotation * Quaternion.Euler (nullRotation.x, nullRotation.y, nullRotation.z));
	}
}
