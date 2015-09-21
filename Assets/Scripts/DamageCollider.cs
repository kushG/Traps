using UnityEngine;
using System.Collections;

public class DamageCollider : MonoBehaviour {

	public GameObject healthBarObject;
	HealthBar healthBar;

	// Use this for initialization
	void Start () {
		healthBar = healthBarObject.GetComponent<HealthBar>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if(col.collider.gameObject.tag == "Player"){
			healthBar.hit =true;
		}
	}

	void OnCollisionExit(Collision col){
		if(col.collider.gameObject.tag == "Player"){
			healthBar.hit = false;
		}
	}
}
