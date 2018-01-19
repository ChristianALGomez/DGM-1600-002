﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guesser_script : MonoBehaviour {

    public int max;
    public int min;
    private int guess;

	// Use this for initialization
	private void Start () {
        print("Wlecome to Number Guesser");
        print("Pick a number between " + min + " and " + max);

        //Is the value GUESS
        NextGuess();
        //Instructions - Push these buttons
        print("Up arrow for higher, Down arrow for lower, Enter for correct");

        //This lets the number reach 1000
        max = max + 1;
	}

    private void NextGuess() {
        guess = (min + max) / 2;
        print("Is the number " + guess + "?");
    }

	// Update is called once per frame
	public void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            print("COMPUTER WIN " + guess + "!");
        }
	}
}
