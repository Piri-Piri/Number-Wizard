﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;
	
	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal");
		
		max = max + 1;	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print ("Up arrow pressed!");
			min = guess;
			guess = (max + min) / 2;
			print ("Is the number higher or lower than " + guess + "?"); 	
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			// print ("Down arrow pressed!");
			max = guess;
			guess = (max + min) / 2;
			print ("Is the number higher or lower than " + guess + "?"); 	
		}
		else if (Input.GetKeyDown(KeyCode.Return)) {
			// print ("I won!");
		}
	}
}