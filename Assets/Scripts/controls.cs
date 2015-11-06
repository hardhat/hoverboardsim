using UnityEngine;
using System.Collections;

public class controls : MonoBehaviour {

	private player playr;

	public bool isGoogleVR;
	public bool isKeyboard;
	public float sensitivity = 0.1f;

	private float joy_01_x;
	private float joy_02_y;



	// Use this for initialization
	void Start () {
	
		GameObject access = GameObject.FindGameObjectWithTag ("Player");
		playr = access.GetComponent<player> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (!isKeyboard) {

			joy_01_x = Input.GetAxis ("Horizontal");
			joy_02_y = Input.GetAxis ("Vertical");


		} else {

			if(Input.GetKey(KeyCode.LeftArrow)){

				joy_01_x = -1f;
			} else

			if(Input.GetKey(KeyCode.RightArrow)){
				
				joy_01_x = 1f;
			}

			if(Input.GetKeyUp(KeyCode.LeftArrow)){
				
				joy_01_x = 0f;
			} else
			
			if(Input.GetKeyUp(KeyCode.RightArrow)){
				
				joy_01_x = 0f;
			}

			if(Input.GetKey(KeyCode.UpArrow)){
				
				joy_02_y = 1f;
			} else

			if(Input.GetKey(KeyCode.DownArrow)){
				
				joy_02_y = -1f;
			}

			if(Input.GetKeyUp(KeyCode.UpArrow)){
				
				joy_02_y = 0f;
			} else 
			
			if(Input.GetKeyUp(KeyCode.DownArrow)){
				
				joy_02_y = 0f;
			}
		}

		//if (joy_02_y >= sensitivity) {
			
			passValues ();
		
		//} else {

			//killValues();
		//}

		}

	void passValues(){

		playr.updateValues (1, joy_01_x, joy_02_y);

		//Debug.Log (joy_01_x + " Values passed " + joy_02_y);
	}

	void killValues(){
		
		playr.updateValues (0, joy_01_x, joy_02_y);

		//Debug.Log ("Values killed");
		
	}
}
