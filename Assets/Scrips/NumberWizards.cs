using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		int max = 1000;
		int min = 1;
		
		print("Welcome to Number Wizard!");
		print("Pick a number in your head, but don't tell to me.");
		print("The lowest number you can pick is " + min + " while the highest number is " + max + ".");
		print("Is the number is higher or lower than 500?");
		print("Up arrow = higher, down = lower, return = equal.");
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.UpArrow)) {
			print("Up arrow is pressed.");
		}
		if(Input.GetKey(KeyCode.DownArrow)) {
			print("Down arrow is pressed.");	
		}
		if(Input.GetKey(KeyCode.Return)) {
			print("Return key is pressed");
		}
		
	}
}
