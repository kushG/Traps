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

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.AddComponent<HingeJoint>().connectedBody = lastObjectOnRope.GetComponent<Rigidbody>();

			col.GetComponent<Rigidbody>().useGravity = false;
			col.transform.localPosition = playerPosition.position;
			col.transform.parent = lastObjectOnRope.transform.parent;
			//col.GetComponent<SphereCollider>().enabled = false;



		}
	}

}
