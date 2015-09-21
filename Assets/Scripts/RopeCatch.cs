using UnityEngine;
using System.Collections;

public class RopeCatch : MonoBehaviour {
	public GameObject lastObjectOnRope;
	public Transform playerPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision col){
		if (col.collider.gameObject.tag == "Player") {
			//col.gameObject.AddComponent<HingeJoint>().connectedBody = lastObjectOnRope.GetComponent<Rigidbody>();

			//col.collider.GetComponent<Rigidbody>().useGravity = false;
			col.collider.transform.position = playerPosition.position;
			//col.collider.transform.parent = lastObjectOnRope.transform.parent;
			//col.GetComponent<SphereCollider>().enabled = false;



		}
	}

}
