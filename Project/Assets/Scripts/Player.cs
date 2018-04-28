using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour {

    public LoopArea loopArea;
    public float minDistanceToObstacleForward;
	public Image image;

    private Vector2 collissionCheckVectorA, collissionCheckVectorB;

	// Use this for initialization
	void Start () {
        collissionCheckVectorA = new Vector2(-gameObject.transform.localScale.x / 2, minDistanceToObstacleForward + gameObject.transform.localScale.y / 2);
        collissionCheckVectorB = new Vector2(gameObject.transform.localScale.x / 2, -gameObject.transform.localScale.y / 2);
    }

	/*void OnCollisionEnter2D (Collision2D c) {
        //Die();
        gameObject.transform.Translate(0, -8f * Time.deltaTime, 0);
	}*/

    public void Die()
    {
        Debug.Log("Dead");
		/*
        float respawnYPos;
        Collider2D[] colliders;
        Vector2 proposedPosition;
        do
        {
            respawnYPos = Random.Range(0f, loopArea.gameObject.transform.position.y);
            proposedPosition = new Vector2(0, respawnYPos);
            colliders = Physics2D.OverlapAreaAll(proposedPosition + collissionCheckVectorA, proposedPosition + collissionCheckVectorB);
        } while (colliders.Length > 0);
*/
		gameObject.transform.position = new Vector3 (0, 0, 0);//proposedPosition;

        //gameObject.transform.localPosition = proposedPosition;


        DeadEffect();
    }

    public void DeadEffect()
    {
        print("Deadeffect invoked");
        image.gameObject.SetActive(true);
        Invoke("hideDeadEffect", 1);
    }

    public void hideDeadEffect()
    {
        image.gameObject.SetActive(false);

    }
}
