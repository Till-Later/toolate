using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0F, 2F) * Time.deltaTime;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position -= new Vector3(4F, 0F) * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += new Vector3(4F, 0F) * Time.deltaTime;
		}		
			
	}
}
