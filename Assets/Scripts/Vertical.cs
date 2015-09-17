using UnityEngine;
using System.Collections;

public class Vertical : MonoBehaviour {
	public Transform A;
	public Transform B;
	public float speed = 1f;
	bool movingUp = true;
	bool movingDown = false;
	public GameObject platform;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (platform.transform.position.x);
		
		
		if (movingUp) {
			platform.transform.Translate (speed * Time.deltaTime, 0, 0);
		}
		
		if (movingDown) {
			platform.transform.Translate (-speed * Time.deltaTime, 0, 0);
		}
		
		
		if(platform.transform.position.y <= B.position.y){
			movingUp = true;
			movingDown = false;
		}
		
		if(platform.transform.position.y >= A.position.y){
			movingUp = false;
			movingDown = true;
		}
		
		
	}
}
