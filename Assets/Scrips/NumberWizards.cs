using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int min = 1;
	int max = 1000;
	int guess = 500;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Printing out the game description
	void StartGame() {
	
		max = max + 1;
		
		print("Welcome to Number Wizard!");
		print("Pick a number in your head, but don't tell to me.");
		print("The lowest number you can pick is " + min + " while the highest number is " + max + ".");
		print("Is the number is higher or lower than "+ guess + "?");
		print("Up arrow = higher, down = lower, return = equal.");
		
	}
	
	// Make the next guess
	void NextGuess() {
		guess = (max + min) / 2;
		print("Higher or lower than " + guess);
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
		
			min = guess;
			NextGuess();
			
		} else if(Input.GetKeyDown(KeyCode.DownArrow)) {
		
			max = guess;
			NextGuess();
			
		} else if(Input.GetKeyDown(KeyCode.Return)) {
		
			print("Victory!");
			
		}
		
	}
}
