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
				GameObject rope = Instantiate(ropePrefab, transform.position, Quaternion.identity) as GameObject;
			}

		}
	}
}
