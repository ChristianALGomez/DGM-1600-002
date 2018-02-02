using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{

    // change States to own states for knight game
    public enum States
    {
        Barrocks, Celler, CourtYard, Tower, Gate, Crack, Cave, RT, MT, LT, Hole,
        StoneStairsDown, OldRuins, EvilCult, MainSt, SkyLight, Freedom, TowerWall, TownSquare, GameOver
    };
    public States currentState;
    public Text textobject;
    public Text Title;


    public int number;


    // Use this for initialization
    void Start()
    {
        currentState = States.Barrocks;
        textobject.alignment = TextAnchor.UpperLeft;
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
            TownsSpuare();
        }
        else if (currentState == States.Cave)
        {
            Cave();
        }
        else if (currentState == States.GameOver)
        {
            GameOver();
        }
    }

    private void Barrocks()
    {
        textobject.text = "You are a Knight who has just woken up to the caslte being attacked. \n" +
            "You can either save the kingdom by shutting the gates or, \n" +
            "Escape and survive. \n" +
            "\n" +
            "1. There is a Celler door in the middle of the room. \n" +
            "3. There is a large wooden door leading outside to the CourtYard. \n" +
            "Press 1 or 3 \n";
        Title.text = "Barrocks";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Celler; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.CourtYard; }
    }

    private void CourtYard()
    {
        textobject.text = "You have entered the CourtYard. \n" +
            "If it wasnt for the sounds of battle it would be a beutiful day to be out side.\n" +
            " \n" +
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
        textobject.text = "The Celler is where you and the other knights would store goods or booze, since its nice and dark to keep the booze for longer time. \n" +
            "Strange in the camotion of the invation it seems that someone had nocked over a shelf breaking the wall revailing an earry crevis leading to who knows where. " +
            "Could this be what you have been looking for...a way out?\n" +
            " \n" +
            "1. Go through the scary looking whole. \n" +
            "2. Head back to the barrocks and find another way. \n";
        Title.text = "Celler";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Crack; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Barrocks; }
    }

    private void Tower()
    {
        textobject.text = "One of many towers surounding the castle built from stone and can withstand most attacks. \n " +
            "1. TowerWall. \n" +
            "2. CourtYard.";
        Title.text = "Tower";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.TowerWall; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.CourtYard; }
    }

    private void TowerWall()
    {
        textobject.text = "At the top of the tower you can see the over the wall and get a good grasp of land.\n" +
            "1. Gate. \n" +
            "2. Tower.";
        Title.text = "TowerWall";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Gate; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Tower; }
    }

    private void Gate()
    {
        print("");
        textobject.text = "You have reached the gate and have been able to close it stoping the enemy from entering the kingdom.\n" +
            "The remaining enemy troops have been delt with by your fellow knights.\n" +
            "For your valiant effort in saving the kingdom you are given a hefty reward and paid time off so you can sleep in as much as you want.";
        Title.text = "Gate:\n" +
            "You Win";

        {
            if (Input.GetKeyDown(KeyCode.O))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            else if (Input.GetKeyDown(KeyCode.X)) { currentState = States.CourtYard; }
        }
    }

    private void Crack()
    {
        textobject.text = "There is a small breaze coming from the hole in the wall, There may be a way out of the kingdom from with in, But the entrence looks unstable." +
            "1. Celler. \n" +
            "2. Cave.";
        Title.text = "Crack";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Celler; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Cave; }

    }

    private void Cave()
    {
        textobject.text = "Crap! The entrence to the cave just collapsed...I guess there is no where else but going forward. There are three tunnels which one should You take." +
            "1. Right Tunnel.\n" +
            "2. Middle Tunnel. \n" +
            "3. Lelft Tunnel";
        Title.text = "Cave";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.RT; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.MT; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { currentState = States.LT; }
    }

    private void RT()
    {
        textobject.text = "Its cold and damp, but you can see a bit of ruble " +
            "1. cave.\n" +
            "2. ruble.";
        Title.text = "Right Tunnel";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Cave; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.SkyLight; }
    }

    private void SkyLight()
    {
        textobject.text = "You see light, this leads to the surface. But, now the question is dose it lead to freedom or right into the enemy.\n" +
            "Maybe there is a safer way out, and is it really ok to leave everyone else behind?" +
            "1. freedom?" +
            "2. Right Tunnel";
        Title.text = "SkyLight";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Freedom; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.RT; }
    }

    private void Freedom()
    {
        textobject.text = "Congrates your gamble paid off you are ontop of a hill over looking the kingdom as it is overtaken. You may have lived but at what cost?" +
            "You Win\n" +
            "Wanna play again?\n" +
            "X  or  O";
        Title.text = "Freedom";

        {
            if (Input.GetKeyDown(KeyCode.O))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            else if (Input.GetKeyDown(KeyCode.X)) { currentState = States.GameOver; }
        }
    }

    private void MT()
    {
        textobject.text = "The tunnel is cold and damp, You see a soft light up a head. It leads to old StoneStairs leading down, it could lead to a mine shaft with an exit.\n" +
            "1. Go down The Stone Stairs.\n" +
            "2. G back to the cave a try a diffrent tunnel.";
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
        textobject.text = "The stairs might not have lead to a mine shaft but it did lead to old ruins forgotten by the kingdom. There is a sound coming deeper into the ruins, sounds like people.\n" +
            "1. Go and investigate the sounds" +
            "2. Lets head back up the stairs";
        Title.text = "OldRuins";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.EvilCult; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.StoneStairsDown; }
    }

    private void EvilCult()
    {
        textobject.text = "As you got closer to the sounds you are ambushed by members of an evil cult who use these ruins as a place to practive thier evil magic.\n" +
            "You are taken to the leader and are now being prepaird to be used for a human sacrifice for one of their dark rituals.\n" +
            "You lose";
        Title.tag = "EvilCult";
        {
            if (Input.GetKeyDown(KeyCode.O))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        {
            if (Input.GetKeyDown(KeyCode.O))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            else if (Input.GetKeyDown(KeyCode.X)) { currentState = States.GameOver; }
        }
    }

    private void LT()
    {
        textobject.text = "The tunnel is dark and damp, it looks like it gose on further than you expected, maybe that means it leads to the exit.";
        Title.text = "Left Tunnel";

        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Hole; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Cave; }
    }

    private void Hole()
    {
        textobject.text = "You Lose\n" +
            "Want to play agian?\n" +
            "X  or  O";
        Title.text = "Hole";
        {
            if (Input.GetKeyDown(KeyCode.O))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        {
            if (Input.GetKeyDown(KeyCode.O))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            else if (Input.GetKeyDown(KeyCode.X)) { currentState = States.GameOver; }
        }
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
        textobject.text = "You lose.\n" +
            "" +
            "Wanna play again?\n" +
            "X  or  O";
        Title.text = "Enemys.";
        {
            if (Input.GetKeyDown(KeyCode.O))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            else if (Input.GetKeyDown(KeyCode.X)) { currentState = States.GameOver; }
        }
    }
    private void GameOver()
    {
        textobject.text = "Thanks for Playing";
        Title.text = "Game Over";
    }


}