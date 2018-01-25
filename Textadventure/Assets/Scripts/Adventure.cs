using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventure : MonoBehaviour {

    // change States to own states for knight game
    public enum States { Barrocks, Celler, Armory, CourtYard, WoodenStairs, Tower, Gate, Crack, Cave, RT, MT, LT, Hole,
        StoneStairsDown, OldRuins, EvilCult, MainSt, SkyLight, Freedom,};
    public States currentState;


    public int number;


    // Use this for initialization
    void Start() {
        currentState = States.Barrocks;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == States.Barrocks)
        {
            Barrocks();
        }
        else if (currentState == States.CourtYard)
        {
            CourtYard();
        }
        else if (currentState == States.Celler)
        {
            Celler();
        }
        else if (currentState == States.Armory)
        {
            Armory();
        }

    }

    private void Barrocks()
    {
        print("You are a Knight who has just woken up to the caslte being attacked. \n" +
            "You can either save the kingdom by shutting the gates or, \n" +
            "Escape and survive. \n" +
            "1. There is a Celler door in the middle of the room. \n" +
            "2. There is a metal door leading to the Armory at the back of the room. \n" +
            "3. There is a large wooden door leading outside to the CourtYard. \n" +
            "Press 1, 2, or 3. \n");
        
        if(Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Celler; }
        if(Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Armory; }
        if(Input.GetKeyDown(KeyCode.Alpha3)) { currentState = States.CourtYard; }
    }

    private void CourtYard()
    {
        print("You have entered the CourtYard. \n" +
            "If it wasnt for the sounds of battle it would be a beutiful day to be out side. \n" +
            "1. Straight ahead leads to the Main Street, which is the quickest way to the Gate. \n" +
            "2. To your right there is a tower that may or may not lead to where you want to go...You have really bad since of direction. \n" +
            "Press 1 to go to the tower, 2 to head down MainStreet, 3 to go back to the barrocks");

        if(Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.WoodenStairs; }
        if(Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.MainSt; }
        if(Input.GetKeyDown(KeyCode.Alpha3)) { currentState = States.Barrocks; }

    }

    private void Celler()
    {
        print("The Celler is where you and the other knights would store goods or booze, since its nice and dark to keep the booze for longer time. \n" +
            "Strange in the camotion of the invation it seems that someone had nocked over a shelf breaking the wall revailing an earry crevis leading to who knows where. \n" +
            "Could this be what you have been looking for...a way out? \n" +
            "1. Go through the scary looking whole. \n" +
            "2. Head back to the barrocks and find another way. \n");

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Crack; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Barrocks; }
    }

    private void Armory()
    {
        print("");
        
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.Barrocks; }
    }
}