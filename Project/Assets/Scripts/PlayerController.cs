using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.GetAxis("Horizontal"));
		//transform.position += new Vector3(16 * Input.GetAxis("Horizontal"), 4F) * Time.deltaTime;
		transform.position += new Vector3(0, 4F) * Time.deltaTime;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position -= new Vector3(12F, 0F) * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += new Vector3(12F, 0F) * Time.deltaTime;
		}		
			
	}
}
