using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public float speed = 50f; 

	private Animator anim;

	private bool active;
	private float steer;
	private float forward;
	public Transform moveNode;
	public bool freeze = false;

	void Start () {
	
		GameObject playerMesh = GameObject.FindGameObjectWithTag ("PlayerMesh");
		anim = playerMesh.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	public void updateValues (int state, float x, float y) {
	
		if (state == 0) {

			active = false;
			anim.SetBool("offBoard", true);
		
		} else {

			active = true;
			anim.SetBool("offBoard", false);

			steer = x;
			forward = y;
		}

		//Debug.Log ("Values received " + steer + " " + forward);
	}

	void Update(){

		if (!freeze) {
			anim.SetFloat ("forward", forward);
			anim.SetFloat ("steer", steer);

			if (active) {

				transform.Translate (Vector3.forward * (Time.deltaTime * (forward * speed)));
				transform.Translate (Vector3.right * ((Time.deltaTime * steer) * (forward * speed)));

				transform.Rotate (Vector3.up * ((Time.deltaTime * steer * 10f) * (forward * speed)));
			}
		}
	}
}
