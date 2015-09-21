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
			Vector3 moveTo = new Vector3(playerPosition.position.x - col.collider.transform.position.x,
			                            playerPosition.position.y - col.collider.transform.position.y, 
			                            0);


			col.collider.transform.Translate(moveTo);
			//col.collider.transform.parent = lastObjectOnRope.transform.parent;
			//col.GetComponent<SphereCollider>().enabled = false;



		}
	}


	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			//col.gameObject.AddComponent<HingeJoint>().connectedBody = lastObjectOnRope.GetComponent<Rigidbody>();
			Debug.Log("Rope Catch");
			//col.GetComponent<Rigidbody>().useGravity = false;
			Vector3 moveTo = new Vector3(playerPosition.position.x - col.transform.position.x,
			                            playerPosition.position.y - col.transform.position.y, 
			                            0);
			
			
			col.transform.Translate(moveTo);
			col.transform.parent = lastObjectOnRope.transform.parent;
			//col.GetComponent<SphereCollider>().enabled = false;
			
			
			
		}
	}

}
