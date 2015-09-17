using UnityEngine;
using System.Collections;

public class Camtriggers12 : MonoBehaviour {
	PlayerMoves playerMoves;
	public Camera cam;
	public float camMoveSpeed = 1.5f;

	// Use this for initialization
	void Start () {
		playerMoves = GameObject.FindObjectOfType<PlayerMoves> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			if(playerMoves.currentCamPos == PlayerMoves.FIRST){
				cam.transform.Translate(0, 4.5f, 0);
				playerMoves.currentCamPos = PlayerMoves.SECOND;
			}
		}
	}
}
