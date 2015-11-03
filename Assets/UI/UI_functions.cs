using UnityEngine;
using System.Collections;

public class UI_functions : MonoBehaviour {

	// Use this for initialization
	public void startGame(){

		Application.LoadLevel (1);
	}

	public void quitProg(){

		Application.Quit ();
	}
}
