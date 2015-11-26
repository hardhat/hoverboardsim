using UnityEngine;
using System.Collections;

public class score_keeper : MonoBehaviour {

	public timer_master timerText;
	public timer_master wpText;
	public timer_master scoreText;

	private float timer;
	private int timer_count;
	private int wp_count;
	private int score = 0;
	private int minute = 3;
	private int second = 00;
	private float trueSec = 0;
	private bool endgame = false;
	private Canvas endbutton;
	private player plyr;

	private waypoint_master wpsys = null;

	// Use this for initialization
	void Start () {
		
		GameObject access = GameObject.Find ("timer_text");
		timerText = access.GetComponent<timer_master> ();
		access = GameObject.Find ("wp_text");
		wpText = access.GetComponent<timer_master> ();
		access = GameObject.Find ("score_text");
		scoreText = access.GetComponent<timer_master> ();
		access = GameObject.Find ("end_button_canvas");
		endbutton = access.GetComponent<Canvas> ();

		access = GameObject.FindWithTag("Player");
		plyr = access.GetComponent<player> ();
	}

	public void sync(waypoint_master wpsystem){

		wpsys = wpsystem;
	}

	void Update () {

		if (!endgame){
		
		trueSec -= Time.deltaTime;
		second = Mathf.CeilToInt (trueSec);

		if (trueSec < 0) {

			minute = minute - 1;
			trueSec = 59;
		}

		if (minute < 1 && second < 1) {

			endGame();

		} else {

			convertInfo();

			//.. resume functions
			
			}
		}
	}

	void convertInfo(){
	
		timerText.info = minute + " : " + second;
		wpText.info = wpsys.count.ToString();

		//Debug.Log (minute + " : " + second);
	}

	public void endGame(){


		endgame = true;

		wp_count = wpsys.count;
		timer_count = (second + (minute) * 60);

		// formula?
		endbutton.enabled = true;
		score = ((second * (minute + 1)) + wpsys.waypointGizmos.Length) - (wp_count + ((second * (minute + 1)) - timer_count));
		
		scoreText.info = "SCORE: " + score;

		plyr.freeze = true;

	}

	public void returnBack(){
		Application.LoadLevel (0);
	}
}
