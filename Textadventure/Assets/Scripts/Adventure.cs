using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{

    // change States to own states for knight game
    public enum States
    {
        Barrocks, Celler, Armory, CourtYard, Tower, Gate, Crack, Cave, RT, MT, LT, Hole,
        StoneStairsDown, OldRuins, EvilCult, MainSt, SkyLight, Freedom, TowerWall, TownSquare
    };
    public States currentState;
    public Text textobject;
    public Text Title;


    public int number;


    // Use this for initialization
    void Start()
    {
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
        else if (currentState == States.Tower)
        {
            Tower();
        }
        else if (currentState == States.Gate)
        {
            Gate();
        }
        else if (currentState == States.TowerWall)
        {
            TowerWall();
        }
        else if (currentState == States.Crack)
        {
            Crack();
        }
        else if (currentState == States.RT)
        {
            RT();
        }
        else if (currentState == States.MT)
        {
            MT();
        }
        else if (currentState == States.LT)
        {
            LT();
        }
        else if (currentState == States.SkyLight)
        {
            SkyLight();
        }
        else if (currentState == States.Freedom)
        {
            Freedom();
        }
        else if (currentState == States.StoneStairsDown)
        {
            StoneStairsDown();
        }
        else if (currentState == States.OldRuins)
        {
            OldRuins();
        }
        else if (currentState == States.EvilCult)
        {
            EvilCult();
        }
        else if (currentState == States.Hole)
        {
            Hole();
        }
        else if (currentState == States.MainSt)
        {
            MainSt();
        }
        else if (currentState == States.TownSquare)
        {
            Enemys();
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
        textobject.text = "You are a Knight who has just woken up to the caslte being attacked. \n" +
            "You can either save the kingdom by shutting the gates or, \n" +
            "Escape and survive. \n" +
            "1. There is a Celler door in the middle of the room. \n" +
            "2. There is a metal door leading to the Armory at the back of the room. \n" +
            "3. There is a large wooden door leading outside to the CourtYard. \n" +
            "Press 1, 2, or 3. \n";
        Title.text = "Barrocks";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Celler; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Armory; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { currentState = States.CourtYard; }
    }

    private void CourtYard()
    {
        print("You have entered the CourtYard. \n" +
            "If it wasnt for the sounds of battle it would be a beutiful day to be out side. \n" +
            "1. Straight ahead leads to the Main Street, which is the quickest way to the Gate. \n" +
            "2. To your right there is a tower that may or may not lead to where you want to go...You have really bad since of direction. \n" +
            "Press 1 to go to the tower, 2 to head down MainStreet, 3 to go back to the barrocks");
        textobject.text = "You have entered the CourtYard. \n" +
            "If it wasnt for the sounds of battle it would be a beutiful day to be out side. \n" +
            "1. Straight ahead leads to the Main Street, which is the quickest way to the Gate. \n" +
            "2. To your right there is a tower that may or may not lead to where you want to go...You have really bad since of direction. \n" +
            "3. Head back to the Barrocks.";
        Title.text = "CourtYard";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.MainSt; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Tower; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { currentState = States.Barrocks; }

    }

    private void Celler()
    {
        print("The Celler is where you and the other knights would store goods or booze, since its nice and dark to keep the booze for longer time. \n" +
            "Strange in the camotion of the invation it seems that someone had nocked over a shelf breaking the wall revailing an earry crevis leading to who knows where. \n" +
            "Could this be what you have been looking for...a way out? \n" +
            "1. Go through the scary looking whole. \n" +
            "2. Head back to the barrocks and find another way. \n");
        textobject.text = "The Celler is where you and the other knights would store goods or booze, since its nice and dark to keep the booze for longer time. \n" +
            "Strange in the camotion of the invation it seems that someone had nocked over a shelf breaking the wall revailing an earry crevis leading to who knows where. \n" +
            "Could this be what you have been looking for...a way out? \n" +
            "1. Go through the scary looking whole. \n" +
            "2. Head back to the barrocks and find another way. \n";
        Title.text = "Celler";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Crack; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Barrocks; }
    }

    private void Armory()
    {
        print("To the contary of the name the Armory is pretty empty. \n" +
            "Over sleeping seems to have left you with only a Sheild and a lamp. \n" +
            "Unfortanitly you where never the most physically gifted aong the knights, so you are only able to take one or the other. \n" +
            "Take the Sheild press S, Take the Lamp press L. \n" +
            "1. Go back to the Barrocks?");
        textobject.text = "To the contary of the name the Armory is pretty empty. \n" +
            "Thats what you get for over sleeping. \n" +
            "1. Go back to the Barrocks.";
        Title.text = "Armory";


        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Barrocks; }
    }

    private void Tower()
    {
        print("");
        textobject.text = "1. TowerWall. \n" +
            "2. CourtYard.";
        Title.text = "Tower";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.TowerWall; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.CourtYard; }
    }

    private void TowerWall()
    {
        print("");
        textobject.text = "1. Gate. \n" +
            "2. Tower.";
        Title.text = "TowerWall";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Gate; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Tower; }
    }

    private void Gate()
    {
        print("");
        textobject.text = "1. TowerWall.";
        Title.text = "Gate";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.TowerWall; }
    }

    private void Crack()
    {
        print("");
        textobject.text = "1. Celler. \n" +
            "2. Cave.";
        Title.text = "Crack";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Celler; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Cave; }

    }

    private void Cave()
    {
        textobject.text = "1. RT.\n" +
            "2. MT. \n" +
            "3. LT";
        Title.text = "Cave";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.RT; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.MT; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { currentState = States.LT; }
    }

    private void RT()
    {
        textobject.text = "";
        Title.text = "Right Tunnel";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Cave; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.SkyLight; }
    }

    private void SkyLight()
    {
        textobject.text = "";
        Title.text = "SkyLight";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Freedom; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.RT; }
    }

    private void Freedom()
    {
        textobject.text = "You Win";
        Title.text = "Freedom";
    }

    private void MT()
    {
        textobject.text = "";
        Title.text = "Middle Tunnel";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.StoneStairsDown; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Cave; }
    }

    private void StoneStairsDown()
    {
        textobject.text = "";
        Title.text = "StoneStairs";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.OldRuins; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Cave; }
    }

    private void OldRuins()
    {
        textobject.text = "";
        Title.text = "OldRuins";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.EvilCult; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.StoneStairsDown; }
    }

    private void EvilCult()
    {
        textobject.text = "You lose";
        Title.tag = "EvilCult";
    }

    private void LT()
    {
        textobject.text = "";
        Title.text = "Left Tunnel";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Hole; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Cave; }
    }

    private void Hole()
    {
        textobject.text = "You Lose";
        Title.text = "Hole";
    }

    private void MainSt()
    {
        textobject.text = "1. CourtYard. \n" +
            "2. TownSquare ";
        Title.text = "MainSt.";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.CourtYard; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.TownSquare; }
     }

    private void TownsSpuare()
    {
        textobject.text = "You lose.";
        Title.text = "Enemys.";
    }
}