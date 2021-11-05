using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpeed : MonoBehaviour{

	private Rigidbody myRigidbody;

	[SerializeField]
	private DoorExplode myDoor;


	[SerializeField]
	private PlayerLevelChange myPlayer;

	private IEnumerator explodeCoroutine;

	private void Start()
	{
		myRigidbody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate() {
		float mySpeed = myRigidbody.velocity.magnitude;
		float explodeSpeed = 4f;
		if (mySpeed > explodeSpeed) {
			explodeCoroutine = Explode();
			StartCoroutine(explodeCoroutine);
		}
	}

	private IEnumerator Explode() {
		yield return new WaitForSecondsRealtime(3);
		float distanceToDoor = Vector3.Distance(myDoor.transform.position, transform.position);
		float distanceToPlayer = Vector3.Distance(myPlayer.transform.position, transform.position);

		if (distanceToDoor < 3f) {
			myDoor.Explode();
		}

		if (distanceToPlayer < 4f) {
			Debug.Log("Player is kill");
			myPlayer.Kill();
		}

		Destroy(this.gameObject);
	}
}