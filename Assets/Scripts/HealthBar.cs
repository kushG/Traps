using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public GameObject damage1;
	public GameObject damage2;
	public GameObject damage3;
	public Collider hitCollider;

	int health = 3;
	public bool hit = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(hit){
			health--;
			switch(health){

			case 3 : break;
			case 2: Destroy(damage3);
				break;
			case 1: Destroy (damage2);
				break;
			case 0 : Destroy(damage1);
				break;
			default: break;

			}

			hit = false;
		}
	
	}
}
