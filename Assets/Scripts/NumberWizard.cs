﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		int max = 1000;
		int min = 1;
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		//print ("Is the number higher or lower than 500?");
		
		//Using division to get the half of max dynamically
		print ("Is the number higher or lower than " + max / 2 + "?");
		
		print ("UP = highr, DOWN = lower, RETURN = equal");
		
		//Input
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("UP arrow pressed");
		}
		
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("DOWN arrow pressed");
		}
	}	
}
