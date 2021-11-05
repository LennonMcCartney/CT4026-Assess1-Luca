using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRes : MonoBehaviour {

	private TMPro.TMP_Dropdown my_dropdown;

	private void Start() {
		my_dropdown = GetComponent<TMPro.TMP_Dropdown>();
	}

	public void SelectResolution() {
		if (my_dropdown.value == 0) {
			Screen.SetResolution(1920, 1080, true);
		}
		else if (my_dropdown.value == 1) {
			Screen.SetResolution(1280, 720, true);
		}
		else if (my_dropdown.value == 2) {
			Screen.SetResolution(1920, 1200, true);
		}
		else if (my_dropdown.value == 1) {
			Screen.SetResolution(3840, 2160, true);
		}
	}
}