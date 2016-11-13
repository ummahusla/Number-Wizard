using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Welcome to Number Wizard!");
		print("Pick a number in your head, but don't tell to me.");
		
		int max = 1000;
		int min = 1;
		
		print("The lowest number you can pick is " + min + " while the highest number is " + max + ".");
		
		print("Is the number is higher or lower than 500");
		print("Up arrow for higher, down for lower, return for equal");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
