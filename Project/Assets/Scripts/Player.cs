using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public LoopArea loopArea;
    public float minDistanceToObstacleForward;

    private Vector2 collissionCheckVectorA, collissionCheckVectorB;

	// Use this for initialization
	void Start () {
        collissionCheckVectorA = new Vector2(-gameObject.transform.localScale.x / 2, minDistanceToObstacleForward + gameObject.transform.localScale.y / 2);
        collissionCheckVectorB = new Vector2(gameObject.transform.localScale.x / 2, -gameObject.transform.localScale.y / 2);
    }
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D c) {
        Die();
	}

    public void Die()
    {
        Debug.Log("Dead");
        float respawnYPos;
        Collider2D[] colliders;
        Vector2 proposedPosition;
        do
        {
            respawnYPos = Random.Range(0f, loopArea.gameObject.transform.position.y);
            proposedPosition = new Vector2(0, respawnYPos);
            colliders = Physics2D.OverlapAreaAll(proposedPosition + collissionCheckVectorA, proposedPosition + collissionCheckVectorB);
        } while (colliders.Length > 0);

        gameObject.transform.localPosition = proposedPosition;
    }
}
