using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHighlighter : MonoBehaviour {
    [SerializeField]
    SpriteRenderer sprite;
    public Animator goalAnim;

    private bool inShow;

    void Start() {
        inShow = false;
    }

    void Update() {
        if (inShow && sprite.color.a > 0)
        {
            Color spriteColor = sprite.color;
            spriteColor.a -= 10f *Time.deltaTime;
            if (spriteColor.a < 0)
            {
                spriteColor.a = 0;
            }
            sprite.color = spriteColor;
        }

        if (!inShow && sprite.color.a < 1)
        {
            Color spriteColor = sprite.color;
            spriteColor.a += 10f * Time.deltaTime;
            if (spriteColor.a > 1)
            {
                spriteColor.a = 1;
            }
            sprite.color = spriteColor;
        }
    }

    void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("Entered");
        /*Color spriteColor = sprite.color;
        spriteColor.a = 0.1f;
        sprite.color = spriteColor;*/

        //goalAnim.SetTrigger("FadeOut");
        inShow = true;
    }

    void OnTriggerExit2D(Collider2D collider) {
        /*Color spriteColor = sprite.color;
        spriteColor.a = 1f;
        sprite.color = spriteColor;*/

        //goalAnim.SetTrigger("FadeIn");
        inShow = false;
    }
}
