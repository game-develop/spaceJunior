using UnityEngine;
using System.Collections;

public class NewBehaviour1 : MonoBehaviour {

	float n = 0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		n+=0.01f;
		Vector3 pos = this.transform.position;
		pos.x += Mathf.Sin (n)/10;
		pos.z += Mathf.Cos (n)/10;
		this.transform.position = pos;

		GameObject.FindWithTag ("Player").rigidbody.collider.material.dynamicFriction = 1f;
		GameObject.FindWithTag ("Respawn").rigidbody.collider.material.dynamicFriction = 1f;
		GameObject.FindWithTag ("Respawn").transform.rigidbody.MoveRotation (GameObject.FindWithTag ("Respawn").transform.rigidbody.rotation * Quaternion.Euler (0, 1, 0.3f));// (0, 0.1f, 0.01f);
		float distance = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, GameObject.FindWithTag("Respawn").transform.position);
		Vector3 v = GameObject.FindWithTag ("Respawn").transform.position - GameObject.FindWithTag ("Player").transform.position;
		v.x /=  distance/10;
		v.y /=  distance/10;
		v.z /=  distance/10;
		//float distance = Vector3.Distance(GameObject.Find("Player").transform.position, GameObject.Find("Respawn").transform.position);
		GameObject.FindWithTag ("Player").rigidbody.AddForce (v);
	}

	void Borsch () {
		//always do nothing
	}
}
