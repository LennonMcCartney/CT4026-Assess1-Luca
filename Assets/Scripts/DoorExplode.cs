using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExplode : MonoBehaviour {

	private Rigidbody myRigidbody;

	private Vector3 explodeForce;

	private void Start() {
		myRigidbody = GetComponent<Rigidbody>();
		explodeForce = new Vector3(-100f, 0f, 0f);
	}

	public void Explode() {
		myRigidbody.isKinematic = false;
		myRigidbody.AddForce(explodeForce);
	}
}