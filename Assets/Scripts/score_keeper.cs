using UnityEngine;
using System.Collections;

public class score_keeper : MonoBehaviour {

	public GUIText timerText;
	private float timer;
	private int minute;
	private int second;
	// Use this for initialization
	void Start () {

		timer = 180f;
	}
	
	// Update is called once per frame
	void Update () {

		timer = timer - Time.deltaTime * 2.5f;

		if (timer < 1) {

			//..stopGame();
		} else {

			convertInfo();
			//.. resume functions
		}
	}

	void convertInfo(){

		minute = Mathf.CeilToInt(timer / 60);
		second = Mathf.CeilToInt(timer) / minute;

		//send info..

		timerText.text = minute + " : " + second;

		//Debug.Log (minute + " : " + second);
	}
	void stopGame(){

		//..
	}
}
