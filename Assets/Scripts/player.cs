using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public float speed = 5f; 

	private bool active;
	private float steer;
	private float forward;
	public Transform moveNode;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void updateValues (int state, float x, float y) {
	
		if (state == 0) {

			active = false;
		
		} else {

			active = true;
			steer = x;
			forward = y;
		}

		//Debug.Log ("Values received " + steer + " " + forward);
	}

	void Update(){

		if (active) {
		
			transform.Translate(Vector3.forward * ( Time.deltaTime * forward));
			transform.Translate(Vector3.right * ( Time.deltaTime * steer ));

		}
	}
}
