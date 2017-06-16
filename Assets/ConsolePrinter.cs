using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrinter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float location = 3.0f;
		float homeLocation = 2.1f;
		float distance = homeLocation - location;
		print ("Welcome to Go Home!");
		print ("A game where you need to find your way back.");
		print ("Distance:" + distance);
		print (distance);
		if (location > homeLocation) {
			print ("Go back");
		}
		if (location < homeLocation) {
			print ("Move on");
		}
		if(location == homeLocation) {
			print ("I am at home.");
		}
	}

	// Update is called once per frame
	void Update () { 
		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			print ("Left key pressed");
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			print ("Right key pressed");
		}


	}
}
