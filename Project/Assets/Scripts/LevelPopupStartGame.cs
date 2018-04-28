using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPopupStartGame : StateMachineBehaviour {
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        Debug.Log("Animationb is done");
        animator.GetComponent<LevelPopup>().playerController.enabled = true;
    }
}
