using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopArea : MonoBehaviour {

    public GameObject startPoint;
    public Player player;

    private Vector2 startPointCoords;
    private Vector2 loopCoords;
    private float loopDistance;

	// Use this for initialization
	void Start () {
        startPointCoords = startPoint.transform.position;
        loopCoords = gameObject.transform.position;
        loopDistance = loopCoords.y - startPointCoords.y;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D()
    {
        SetToStart();
    }

    public void SetToStart()
    {
        player.gameObject.transform.Translate(0, -loopDistance, 0);
    }
}
