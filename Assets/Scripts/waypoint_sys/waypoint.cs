using UnityEngine;
using System.Collections;

public class waypoint : MonoBehaviour {

	private waypoint_master par;
	// Use this for initialization
	public void syncData (waypoint_master mom) {
	
		par = mom;
		Debug.Log("sync made to " + par.name);
	}
	
	void OnTriggerEnter(Collider plyr){

		if (plyr.gameObject.tag == "Player") {

			par.removeChild(this.gameObject);
		}
	}
}
