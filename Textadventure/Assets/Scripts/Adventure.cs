using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventure : MonoBehaviour {

    // change States to own states for knight game
    public enum States { cell, window, gate, bed};
    public States currentState;


    public int number;


    // Use this for initialization
    void Start() {
        currentState = States.cell;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == States.cell)
        {
            Cell();
        }
        else if (currentState == States.bed)
        {
            Bed();
        }
        else if (currentState == States.window)
        {
            Window();
        }
        else if (currentState == States.gate)
        {
            Gate();
        }

    }

    private void Cell()
    {
        print("You are in a cell, it is small dark and stinky. \n" +
            "There is a Window. \n" +
            "There is a Gate. \n" +
            "There is a Bed. \n" +
            "Press W for Window, G for Gate, B for Bed \n");
        
        if(Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if(Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if(Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    
    private void Bed()
    {
        print("The bed is moldy, torn, and the sorce of the smell. \n" +
            "There is a Window. \n" +
            "There is a Gate. \n" +
            "There is a Cell. \n" +
            "Press W for Window, G for Gate, C for Cell. \n");

        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }

    private void Window()
    {
        print("There are bars on the window, outside you can see a highwall, trees, and two gaurds. \n" +
            "There is a Gate. \n" +
            "There is a Bed. \n" +
            "There is a Cell. \n" +
            "Press G for Gate, B for Bed, C for Cell. \n");

        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }
    
    private void Gate()
    {
        print("It is old and made out of wood, the hinges are very rusty. \n" +
            "There is a Bed. \n" +
            "There is a Window. \n" +
            "There is a Cell. \n" +
            "Press B for bed, W for window, C for Cell. \n");

        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }
}