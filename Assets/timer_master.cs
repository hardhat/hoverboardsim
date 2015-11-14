using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer_master : MonoBehaviour {

	public string info = "";
	private Text str;

	void Start(){

		str = this.GetComponent<Text> ();

	}
	// Update is called once per frame
	void FixedUpdate () {
	
		str.text = info;
	}
}
