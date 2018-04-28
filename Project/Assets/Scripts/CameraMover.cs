using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

    public Player player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.localPosition = new Vector3(gameObject.transform.position.x, player.gameObject.transform.position.y, 0);
	}
}
