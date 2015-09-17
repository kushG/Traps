using UnityEngine;
using System.Collections;

public class Horizontal : MonoBehaviour {
	public Transform A;
	public Transform B;
	public float speed = 0.2f;
	bool movingLeft = true;
	bool movingRight = false;
	public GameObject platform;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (movingLeft) {
			platform.transform.Translate (0, speed * Time.deltaTime, 0);
		}

		if (movingRight) {
			platform.transform.Translate (0, -speed * Time.deltaTime, 0);
		}

		if(platform.transform.position.x >= B.position.x){
			movingLeft = true;
			movingRight = false;
		}

		if(platform.transform.position.x <= A.position.x){
			movingLeft = false;
			movingRight = true;
		}


	}
}
