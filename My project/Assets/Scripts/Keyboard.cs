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

    public void PressEnter()
    {
        _game.Guess();
    }
}
