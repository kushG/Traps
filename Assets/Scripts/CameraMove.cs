using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public static bool FIRST = false;
	public static bool SECOND = false;
	public static bool THIRD = false;
	public static bool FOURTH = false;
	public static bool fromThird = false;
	public static bool fromFirst = false;
	public static bool fromSecond = false;
	public static bool fromFourth = false;

	public float camMoveSpeed = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (FIRST) {
			// implies transition from second
			transform.Translate (0, -camMoveSpeed * Time.deltaTime, 0);
			FIRST = false;
		}

		if (SECOND) {
			// implies transition from first or third
			if(fromFirst){
				transform.Translate (0, camMoveSpeed * Time.deltaTime, 0);
			}

			if(fromThird){
				transform.Translate (-camMoveSpeed * Time.deltaTime, 0, 0);
			}
			SECOND = false;
		}

		if (THIRD) {
			// implies transition from second or fourth
			if(fromFourth){
				transform.Translate (0, camMoveSpeed * Time.deltaTime, 0);
			}
			
			if(fromSecond){
				transform.Translate (camMoveSpeed * Time.deltaTime, 0, 0);
			}
			THIRD =false;
		}

		if (FOURTH) {
			// implies transition from third
			transform.Translate (0, -camMoveSpeed * Time.deltaTime, 0);
			FOURTH = false;
		}


	}
}
