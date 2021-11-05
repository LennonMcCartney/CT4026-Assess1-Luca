using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PlayerLevelChange : MonoBehaviour {

	private void Update() {
		if (Keyboard.current.escapeKey.wasPressedThisFrame) {
			SceneManager.LoadScene("MenuScene");
		}
	}

	public void Kill() {
		SceneManager.LoadScene("DiedScene");
	}
}
