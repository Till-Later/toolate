using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPopupNextLevel : StateMachineBehaviour {
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        Debug.Log("next scene index " + nextSceneIndex + "  " + SceneManager.sceneCountInBuildSettings);
        if(SceneManager.sceneCountInBuildSettings > nextSceneIndex) {
            Debug.Log("load #" + nextSceneIndex);
            SceneManager.LoadScene(nextSceneIndex);
        } else {
            Debug.Log("KLoad 0");
            SceneManager.LoadScene(0);
        }
	}
}
