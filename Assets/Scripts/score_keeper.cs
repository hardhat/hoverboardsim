using UnityEngine;
using System.Collections;

public class score_keeper : MonoBehaviour {

	public GUIText timerText;
	private float timer;
	private int timer_count;
	private int wp_count;
	private int score;
	private int minute;
	private int second;
	public int fullTime = 180;

	private waypoint_master wpsys = null;

	// Use this for initialization
	void Start () {

		timer = fullTime;
	}

	public void sync(waypoint_master wpsystem){

		wpsys = wpsystem;
	}

	void Update () {

		timer = timer - Time.deltaTime * 2.5f;

		if (timer < 1) {

			endGame();

		} else {

			convertInfo();

			//.. resume functions
		}
	}

	void convertInfo(){

		minute = Mathf.CeilToInt(timer / 60);
		second = Mathf.CeilToInt(timer) / minute;

		//send info..

		// !!! timerText.text = minute + " : " + second;

		Debug.Log (minute + " : " + second);
	}

	public void endGame(){

		wp_count = wpsys.count;
		timer_count = fullTime - Mathf.CeilToInt(timer);

		// formula?

		score = (fullTime + wpsys.waypointGizmos.Length) - (wp_count + (fullTime - timer_count));

	}
}
