using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Guesser_script : MonoBehaviour {

    public int max;
    public int min;
    private int guess;
    public int count;

	// Use this for initialization
	private void Start () {
        //SceneManager.LoadScene(01);
        //SceneManager.LoadSceneAsync(01);
        {
            print("Wlecome to Number Guesser");
            print("Pick a number between " + min + " and " + max);

            //Is the value GUESS
            NextGuess();
            //Instructions - Push these buttons
            print("Up arrow for higher, Down arrow for lower, Enter for correct");

            //This lets the number reach 1000
            max = max + 1;
        }
	}

    private void NextGuess() {
        count--;
        //get guess to be random
        //guess = (min + max) / 2;
        guess = Random.Range(min, max);
        print("Is the number " + guess + "?");
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("COMPUTER WIN " + guess + "!");
            print("Wanna play again? O or X");
            
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            print("YOU WIN!");
            print("Wanna play again? O or X");
            
        }
        else if (count == 0)
        {
            print("Is this your number " + guess + "? If yes click enter, if not click N");
            
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            print("Thanks for playing");
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //NextGuess();
            //print("Me too...just have to figure out how to do that");
        }
    }
}
