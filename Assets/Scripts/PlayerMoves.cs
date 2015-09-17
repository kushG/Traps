using UnityEngine;
using System.Collections;

public class PlayerMoves : MonoBehaviour {

	public Animation Move;
	public Animation Jump;
	public Animation Idle;
	public Animation crouch;
	public float speed = 0.5f;
	public bool steps = false;
	public bool door = false;
	public float jumpSpeed = 5.0f;
	public Rigidbody rigidBody;
	public GameObject referenceDoor;
	
	public static int FIRST = 1;
	public static int SECOND = 2;
	public static int THIRD = 3;
	public static int FOURTH = 4;

	public int currentCamPos = 1;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//up
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {

		}

		// Down
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			
		}

		//Left
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-speed * Time.deltaTime, 0, 0);
		}

		//Right
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (speed * Time.deltaTime, 0, 0);
			GetComponent<Rigidbody>().AddForce(-Vector3.up * Time.deltaTime * 20.0f);
		}

		//Jump
		if (Input.GetKey (KeyCode.Space) && !steps) {
			transform.Translate (0, jumpSpeed * Time.deltaTime, 0);
		}

		/*if (Input.GetKey (KeyCode.Space)) {
			if (Input.GetKey(KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
				Debug.Log("Works in left");
				transform.Translate (-speed * Time.deltaTime, 0, 0);
			}

			if (Input.GetKey(KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
				Debug.Log("Works in Right");
				transform.Translate (speed * Time.deltaTime, 0, 0);
			}
		}*/


		if (steps) {
			// Climb up
			if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
				transform.Translate(0, speed * Time.deltaTime, 0);
			}
			
			// Climb Down
			if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
				transform.Translate(0, -speed * Time.deltaTime, 0);
			}
		}

		if (door) {
			// Come out of referenced door
			if (Input.GetKeyDown (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
				transform.position = referenceDoor.transform.position;
			}

		}


	}
}
