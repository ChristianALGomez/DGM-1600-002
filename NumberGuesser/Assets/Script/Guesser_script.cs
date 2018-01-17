using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guesser_script : MonoBehaviour {

    public int max;
    public int min;
    public int guess;

	// Use this for initialization
	private void Start () {
        print("Wlecome to Number Guesser");
        print("Pick a number between " + min + " and " + max);

        //Is the value GUESS
        print("Is the number " + guess + "?");
        //Instructions - Push these buttons
        print("Up arrow for higher, Down arrow for lower, Enter for correct");

	}
	
	// Update is called once per frame
	public void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            guess = (min + max) / 2;
            print("Is the number " + guess + "?");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            guess = (min + max) / 2;
            print("is the number " + guess + "?");
        }
	}
}
