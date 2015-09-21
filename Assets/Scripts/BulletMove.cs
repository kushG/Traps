using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * speed * Time.deltaTime);
	}


	void OnCollisionEnter(Collision col){
		Destroy(gameObject);
	}


	
}
