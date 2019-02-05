using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {

	void Start() {

	}


	void Update () {

		float speed = 10;

		if (Input.GetKey("right")) {
			transform.Rotate(Vector3.up * speed * Time.deltaTime);
		}
		else if (Input.GetKey("left")) {
			transform.Rotate(Vector3.up * -1 * speed * Time.deltaTime);
		}
		else if (Input.GetKey("up")) {
			transform.Rotate(Vector3.right * speed * Time.deltaTime);
		}
		else if (Input.GetKey("down")) {
			transform.Rotate(Vector3.right * -1 * speed * Time.deltaTime);
		}

	}

}
