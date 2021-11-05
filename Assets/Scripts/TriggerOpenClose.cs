using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOpenClose : MonoBehaviour {
    //[SerializeField]
    //private GameObject door1;

    [SerializeField]
    private Animator animator;

    private void OnTriggerEnter(Collider other) {
        animator.SetBool("isTriggered", true);
    }

    private void OnTriggerExit(Collider other) {
        animator.SetBool("isTriggered", false);
    }
}
