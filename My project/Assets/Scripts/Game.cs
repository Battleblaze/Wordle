using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    
    public GameObject currentBox;

    public string correctWord;
    public string currentGuess;
    private int numberOfGuesses;
    
    
    void Start()
    {
        UpdateGuess(numberOfGuesses);
    }

    public void AddToGuess(string a)
    {
        
        currentGuess += a;
        UpdateBox(a);
        
    }

    public void Guess()
    {
        if (currentGuess == correctWord)
        {
            Debug.Log("You Won!!!");
        }
        else
        {
            numberOfGuesses++;
            UpdateGuess(numberOfGuesses);
        }
    }

    GameObject UpdateGuess(int guess)
    {
        if(guess == 0)
        {
            return GameObject.Find("Word1");
        }
        if(guess == 1)
        {
            return GameObject.Find("Word2");
        }
        if(guess == 2)
        {
            return GameObject.Find("Word3");
        }
        if(guess == 3)
        {
            return GameObject.Find("Word4");
        }
        else
        {
            return gameObject;
        }
        
    }

    void UpdateBox(string a)
    {
        Debug.Log(UpdateGuess(numberOfGuesses).transform.GetChild(0));
        UpdateGuess(numberOfGuesses).GetComponentInChildren<Text>().text = a;
    }
    

}
