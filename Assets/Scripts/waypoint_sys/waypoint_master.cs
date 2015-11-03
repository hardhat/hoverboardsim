using UnityEngine;
using System.Collections;

public class waypoint_master : MonoBehaviour {

	public Transform[] waypointGizmos;
	public GameObject waypointPrefab;
	private GameObject waypoint;
	public int count;
	// Use this for initialization
	void Start () {

		addChild ();
		count = 0;
	}

	private void addChild(){

		waypoint = GameObject.Instantiate (waypointPrefab) as GameObject;
		waypoint.GetComponent<waypoint>().syncData(this);
		waypoint.transform.position = waypointGizmos[count].position;
	}

	public void removeChild(GameObject kid){

		count++;
		Destroy (kid);
		addChild ();
	}
}
