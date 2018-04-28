using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPopup : MonoBehaviour {
    public PlayerController playerController;
    public Animator animator;

    public void EndLevel() {
        playerController.enabled = false;
        playerController.GetComponent<Rigidbody2D>().simulated = false;
        animator.SetTrigger("End");
    }

    void Update() {
     //   if(Input.GetKeyDown(KeyCode.Space)) { EndLevel(); }
    }
}
