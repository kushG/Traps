using UnityEngine;
using System.Collections;

public class EnemyFire : MonoBehaviour {

	public GameObject bullet;
	public float bulletspawnTime = 2.0f;
	float tempTime;
	// Use this for initialization
	void Start () {
		tempTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if((Time.time - tempTime)>bulletspawnTime){
			Instantiate(bullet,new Vector3(transform.position.x - 0.5f, transform.position.y + 0.1f, transform.position.z), Quaternion.Euler(0, 0, 90));	
			tempTime = Time.time;
		}
	
	}
}
