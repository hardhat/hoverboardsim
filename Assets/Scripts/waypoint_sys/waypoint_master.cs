using UnityEngine;
using System.Collections;

public class waypoint_master : MonoBehaviour {

	public Transform[] waypointGizmos;
	public GameObject waypointPrefab;
	public GameObject falseWpPrefab;
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
		addFalseChild ();
	}

	private void addFalseChild(){

		float t = 5f;
		float u = 1f;
		float tt = t * t;
		float uu = u * u;
		float uuu = uu * u;
		float ttt = tt * t;

		Vector3 firstPos = waypointGizmos[count].position;
		if (waypointGizmos [count + 1] == !null) {
		
			Vector3 secPos = waypointGizmos [count + 1].position;
		
		} else {

			return;
		}

		Vector3 tweenPoint_01;
		Vector3 tweenPoint_02;
		Vector3 tweenPoint_03;
		Vector3 tweenPoint_05;
		Vector3 tweenPoint_06;

		tweenPoint_01 = 

	}

	public void removeChild(GameObject kid){

		count++;
		Destroy (kid);
		addChild ();
	}
}
