﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate () {
        //Debug.Log(Input.GetAxis("Horizontal"));
        //transform.position += new Vector3(12 * Input.GetAxisRaw("Horizontal"), 6F) * Time.deltaTime;
		rb.transform.Translate(new Vector3(12 * Input.GetAxisRaw("Horizontal"), 6F) * Time.fixedDeltaTime);
		/*
		transform.position += new Vector3(0F, 6F) * Time.deltaTime;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position -= new Vector3(12F, 0F) * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += new Vector3(12F, 0F) * Time.deltaTime;
		}*/

	}
}
