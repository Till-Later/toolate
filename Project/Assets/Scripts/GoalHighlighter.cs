using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHighlighter : MonoBehaviour {
    [SerializeField]
    SpriteRenderer sprite;

    void Start() {

    }

    void Update() {

    }

    void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("Entered");
        Color spriteColor = sprite.color;
        spriteColor.a = 0.1f;
        sprite.color = spriteColor;
    }

    void OnTriggerExit2D(Collider2D collider) {
        Color spriteColor = sprite.color;
        spriteColor.a = 1f;
        sprite.color = spriteColor;
    }
}
