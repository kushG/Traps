using UnityEngine;
using System.Collections;

public class Falling : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if(col.collider.gameObject.tag == "Player"){
			Rigidbody rb = gameObject.AddComponent<Rigidbody> ();
			rb.useGravity = true;
			rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ;
			                                                         
		}
	}

}
