using UnityEngine;
using System.Collections;

public class Camtriggers32 : MonoBehaviour {
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
			if(playerMoves.currentCamPos == PlayerMoves.THIRD){
				cam.transform.Translate(-10.0f, 0, 0);
				cam.orthographicSize -= 0.5f;
				playerMoves.currentCamPos = PlayerMoves.SECOND;
			}
		}
	}
}
