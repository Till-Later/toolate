using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
    [SerializeField]
	public LevelPopup popup;

    [SerializeField] SpriteRenderer sprite;

    void Start () {

	}
	
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D collider) {
        Color spriteColor = sprite.color;
        spriteColor.a = 0.5f;
        sprite.color = spriteColor;
        Debug.Log("Great!");
		popup.EndLevel();

        transform.parent.GetComponentInChildren<GoalHighlighter>().enabled = false;
    }
}
