using UnityEngine;
using System.Collections;

public class waypoint : MonoBehaviour {

	private waypoint_master parent;
	// Use this for initialization
	public void syncData (waypoint_master mom) {
	
		parent = mom;
	}
	
	void OnCollisionEnter(Collision plyr){

		if (plyr.gameObject.tag == "Player") {

			parent.removeChild(this.gameObject);
		}
	}
}
