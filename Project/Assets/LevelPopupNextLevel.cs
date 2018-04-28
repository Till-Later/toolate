using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPopupNextLevel : StateMachineBehaviour {
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        int nextTeamIndex = SceneManager.GetActiveScene().buildIndex;
        if(SceneManager.sceneCount > nextTeamIndex) {
            SceneManager.LoadScene(nextTeamIndex);
        } else {
            SceneManager.LoadScene(0);
        }
	}
}
