using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour {

	public float maxPositionShift = 0;
	public float speed = 1;
	float positionShift = 0;
	bool positive = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (positive) {
			positionShift += speed;
			transform.position += new Vector3 (speed,0F,0F) * Time.deltaTime;	
			if (positionShift > 2*maxPositionShift)
				positive = !positive;
		} else {
			positionShift -= speed;
			transform.position -= new Vector3 (speed,0F,0F) * Time.deltaTime;	
			if (positionShift < 0)
				positive = !positive;
		}

	}
}
