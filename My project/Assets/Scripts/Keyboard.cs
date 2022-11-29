using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    private GameObject box1;
    private Game _game;
    private GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        
        _game = GameObject.Find("GameManager").GetComponent<Game>();
    }
    
    public void pressQ()
    {
        _game.AddToGuess("Q");

    }
    public void pressW()
    {
        _game.AddToGuess("W");

    }
    public void pressE()
    {
        _game.AddToGuess("E");

    }
    public void pressR()
    {
        _game.AddToGuess("R");

    }
    public void pressT()
    {
        _game.AddToGuess("T");

    }
    public void pressY()
    {
        _game.AddToGuess("Y");

    }
    public void pressU()
    {
        _game.AddToGuess("U");

    }
    public void pressI()
    {
        _game.AddToGuess("I");

    }
    public void pressO()
    {
        _game.AddToGuess("O");

    }
    public void pressP()
    {
        _game.AddToGuess("P");

    }
    public void pressÅ()
    {
        _game.AddToGuess("Å");

    }
    public void pressA()
    {
        _game.AddToGuess("A");

    }
    public void pressS()
    {
        _game.AddToGuess("S");

    }
    public void pressD()
    {
        _game.AddToGuess("D");

    }
    public void pressF()
    {
        _game.AddToGuess("F");

    }
    public void pressG()
    {
        _game.AddToGuess("G");

    }
    public void pressH()
    {
        _game.AddToGuess("H");

    }
    public void pressJ()
    {
        _game.AddToGuess("J");

    }
    public void pressK()
    {
        _game.AddToGuess("K");

    }
    public void pressL()
    {
        _game.AddToGuess("L");

    }
    public void pressÖ()
    {
        _game.AddToGuess("Ö");

    }
    public void pressÄ()
    {
        _game.AddToGuess("Ä");

    }
    public void pressZ()
    {
        _game.AddToGuess("Z");

    }
    public void pressX()
    {
        _game.AddToGuess("X");

    }
    public void pressC()
    {
        _game.AddToGuess("C");

    }
    public void pressV()
    {
        _game.AddToGuess("V");

    }
    public void pressB()
    {
        _game.AddToGuess("B");

    }
    public void pressN()
    {
        _game.AddToGuess("N");

    }
    public void pressM()
    {
        _game.AddToGuess("M");

    }

    public void PressEnter()
    {
        _game.Guess();
    }

    public void PressErase()
    {
        _game.Erase();
    }
}
