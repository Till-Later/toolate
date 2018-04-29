using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    new private Rigidbody2D rigidbody2D;
    private float verticalSpeed = 6f;
    private float horizontalSpeed = 12f;
    void Start () {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
        if(Input.GetMouseButton(0)) {
            rigidbody2D.transform.Translate(Mathf.Clamp(Input.mousePosition.x - Camera.main.WorldToScreenPoint(transform.position).x, -horizontalSpeed, horizontalSpeed) * Time.fixedDeltaTime, verticalSpeed * Time.fixedDeltaTime, 0f);
        } else {
            rigidbody2D.transform.Translate(new Vector3(horizontalSpeed * Input.GetAxisRaw("Horizontal"), verticalSpeed) * Time.fixedDeltaTime);
        }
    }
}
