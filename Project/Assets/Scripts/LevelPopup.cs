using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPopup : MonoBehaviour {
    public PlayerController playerController;
    public Animator animator;

    public void EndLevel() {
        animator.SetTrigger("End");
    }

    void Update() {
     //   if(Input.GetKeyDown(KeyCode.Space)) { EndLevel(); }
    }
}
