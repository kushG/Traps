using UnityEngine;
using System.Collections;

public class RopeSpawn : MonoBehaviour {
	PlayerMoves player;
	public GameObject ropePrefab;
	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<PlayerMoves>();
		player.hasRope = true;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(player.hasRope){
			if(Input.GetKeyDown(KeyCode.E)){
				Debug.Log("Horizontal" + Input.GetAxis("Horizontal"));
				Debug.Log("Vertical" + Input.GetAxis("Vertical"));
				GameObject rope = Instantiate(ropePrefab, transform.position, Quaternion.identity) as GameObject;
				rope.transform.LookAt(new Vector3(Input.GetAxis("Horizontal"),
				                                  Input.GetAxis("Vertical"), 0));
				rope.transform.Translate(Vector3.forward);

			}

		}
	}
}
