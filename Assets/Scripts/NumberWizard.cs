using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start (){
	
		StartGame();
	}
	
	
	
	void StartGame (){
	
// BUG 01 [Fixed]
//**If I type int max = value; it will not refer to the variables initialised in the begining**
		max = 1000;
		min = 1;
		guess = 500;
		
		max = max + 1;
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		// BUG 02 [Fixed]
		// Max displaying as 1001 instead of 1000. Hard-coded 1000.
		// print ("The lowest number you can pick is " + max);
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
			StartGame();
		}
	}	
	
	void NextGuess() {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");	
		print ("UP = highr, DOWN = lower, RETURN = equal");
	}
}
