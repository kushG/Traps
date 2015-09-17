using UnityEngine;
using System.Collections;

public class SliderMove : MonoBehaviour {
	public float slideSpeed = 1.0f;
	bool collided = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (collided) {
			transform.Translate (-slideSpeed * Time.deltaTime, 0, 0);
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.collider.gameObject.tag == "Player") {
			collided = true;
			Debug.Log("Slider Collision");
		}
	}
}
