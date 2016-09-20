using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

    int max;
    int min;
    int guess;

	// Use this for initialization
	void Start () {
        StartGame();
	}

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;
        
        print("========================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head but don't tell me");
        print("The highest is " + max + " and lowest is " + min);
        print("Is it higher or lower than " + guess);
        //do this to avoid rounding down 
        max += 1;
    }

    //run when need to update the guess
    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
        print("Press up for higher, down for lower, enter if it's the one");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        //use else if so we only check 1 statement at a time
        //other than check all statments at once when using only if
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I got it!");
            StartGame();
        }
	
	}
}
