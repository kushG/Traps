using UnityEngine;
using System.Collections;

public class RopeRotate : MonoBehaviour {
	public float minRotation;
	public float maxRotation;
	public float speed;
	public float center;

	bool rotatePositive = true;
	bool rotateNegative = false;

	float signedEulerAngle = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.rotation.eulerAngles.z > 180) {
			 signedEulerAngle = transform.rotation.eulerAngles.z - 360;
		}
		else
			signedEulerAngle = transform.rotation.eulerAngles.z;

		if (rotatePositive) {
			transform.Rotate(0, 0, speed * Time.deltaTime);
		}

		if (rotateNegative) {
			transform.Rotate(0, 0, -speed * Time.deltaTime);
		}

		if (signedEulerAngle <= minRotation) {
			rotatePositive = true;
			rotateNegative = false;

		}

		if (signedEulerAngle >= maxRotation) {
			rotateNegative = true;
			rotatePositive = false;

        }

	}
}
