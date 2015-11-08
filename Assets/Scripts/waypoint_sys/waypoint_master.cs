using UnityEngine;
using System.Collections;

public class waypoint_master : MonoBehaviour {

	public Transform[] waypointGizmos;
	public GameObject waypointPrefab;
	public GameObject falseWpPrefab;
	private GameObject waypoint;
	public int count;

	private score_keeper master;

	// Use this for initialization
	void Start () {

		addChild ();
		count = 0;

		GameObject masterGO = GameObject.FindWithTag ("Master");
		master = masterGO.GetComponent<score_keeper> ();
		master.sync ();
	}

	private void addChild(){

		waypoint = GameObject.Instantiate (waypointPrefab) as GameObject;
		waypoint.GetComponent<waypoint>().syncData(this);
		waypoint.transform.position = waypointGizmos[count].position;
		addFalseChild ();
	}

	/**private void addFalseChild(){

		float t = 5f;
		float u = 1f;
		float tt = t * t;
		float uu = u * u;
		float uuu = uu * u;
		float ttt = tt * t;

		Vector3 firstPos = waypointGizmos[count].position;

		if (waypointGizmos [count + 1] != null) {
		
		Vector3 secPos = waypointGizmos[count + 1].position;
		
		} else {

			return;
		}

		//Vector3 tweenPoints[];

		for (int i = 0; i < 5; i++) {

			tweenPoints[i] = 
		}

		//tweenPoint_01 =

	} **/

	public void removeChild(GameObject kid){

		count++;
		Destroy (kid.gameObject);

		if (count != waypointGizmos.Length) {
		
			addChild ();
		}

		if (count == waypointGizmos.Length){

			Debug.Log("finish game");
		}
	}
}
