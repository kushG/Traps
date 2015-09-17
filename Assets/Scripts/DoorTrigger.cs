using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	PlayerMoves playerMoves;
	public GameObject referenceDoor;
	// Use this for initialization
	void Start () {
		playerMoves = GameObject.FindObjectOfType<PlayerMoves> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			playerMoves.referenceDoor = referenceDoor;
			playerMoves.door = true;
		}
	}
	
	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "Player") {
			playerMoves.referenceDoor = null;
			playerMoves.door = false;
		}
	}


}
