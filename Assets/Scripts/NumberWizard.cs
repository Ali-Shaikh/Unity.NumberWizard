﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{

	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start (){
	
		StartGame();
	}
	
	
	
	void StartGame (){
	
		max = max + 1;
		
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is 1000");
		print ("The lowest number you can pick is " + min);
		
		//print ("Is the number higher or lower than 500?");
		print ("Is the number higher or lower than " + guess + "?");
		
		
		//Using division to get the half of max dynamically
		//print ("Is the number higher or lower than " + max / 2 + "?");
		
		print ("UP = highr, DOWN = lower, RETURN = equal");
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I WON!");
		}
	}	
	
	void NextGuess() {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");	
		print ("UP = highr, DOWN = lower, RETURN = equal");
	}
}
