using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    //declare 2 iniger variables
    int max;
    int min;
    int guess;

    void NextGuess()
    {

        Debug.Log("Is the nuber smaller or Bigger than" + guess + "?");
        Debug.Log("Press UP if number is bigger");
        Debug.Log("Press Down if number is Smaller");
        Debug.Log("Press Enter if number is Answered");
    }

    void StartGame()
    {
        min = 1;
        max = 1001;
        guess = 500;

        print("Welcome to Number Wizard");
        Debug.Log("Please choose a number between " + min + " to " + max); //outputting through console
        NextGuess();

    }


    // Use this for initialization
    void Start() {

        StartGame();
    }
        // Update is called once per frame
        void Update() {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                print("Up arrow Pressed");
                min = guess;
                guess = (max + min) / 2;
                NextGuess();
            }

            else

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                print("Down arrow Pressed");
                max = guess;
                guess = (max + min) / 2;
                NextGuess();

            }

            else

            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                print("KeypadEnter arrow Pressed");
                print("The Number you chose Was " + guess);
                print(" Left Arrow to Play Again or  Right Arrow to Quit ?");


                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    print("Quit");
                    UnityEditor.EditorApplication.isPlaying = false;
                }

                else
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                StartGame();
            }

            }




        }
    }
