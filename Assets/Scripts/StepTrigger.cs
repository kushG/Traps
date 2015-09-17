using UnityEngine;
using System.Collections;

public class StepTrigger : MonoBehaviour {
	PlayerMoves playerMoves;
	// Use this for initialization
	void Start () {
		playerMoves = GameObject.FindObjectOfType<PlayerMoves> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			playerMoves.steps = true;
			playerMoves.rigidBody.useGravity = false;
		}
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "Player") {
			playerMoves.rigidBody.useGravity = true;
			playerMoves.steps = false;
		}
	}

}
