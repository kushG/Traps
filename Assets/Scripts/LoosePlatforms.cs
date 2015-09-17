using UnityEngine;
using System.Collections;

public class LoosePlatforms : MonoBehaviour {
	bool collided = false;
	bool respawn = false;
	public float holdTime = 0.7f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (collided) {
			StartCoroutine(DestroyObject());
			collided = false;
		}
		if (respawn) {
			Debug.Log("In Respawn");
			StartCoroutine(RespawnObject());
			respawn = false;
		}
	}
	

	void OnCollisionEnter(Collision col){
		if (col.collider.gameObject.tag == "Player") {
			collided = true;
		}
	}

	IEnumerator DestroyObject(){
		yield return new WaitForSeconds(0.7f);
		GetComponent<MeshRenderer> ().enabled = false;
		GetComponent<BoxCollider> ().enabled = false;
		respawn = true;
	}

	IEnumerator RespawnObject(){
		yield return new WaitForSeconds(3.0f);
		GetComponent<MeshRenderer> ().enabled = true;
		GetComponent<BoxCollider> ().enabled = true;

	}

}
