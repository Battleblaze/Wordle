using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    
    public GameObject currentBox;

    public string correctWord;
    public string currentGuess;
    private int numberOfGuesses;
    private int charLenght;
    private WordList _wordList;
    
    
    void Start()
    {
        _wordList = GameObject.Find("GameManager").GetComponent<WordList>();
        UpdateGuess(numberOfGuesses);
        charLenght = 0;
        CreateCorrectWord();
    }

    public void AddToGuess(string a)
    {
        currentGuess += a;
        UpdateBox(a);
    }

    public void Guess()
    {
        for (int i = 0; i < _wordList.Words.Length; i++)
        {
          if (currentGuess == _wordList.Words[i])
          {
              if (currentGuess == correctWord)
              {
                  Debug.Log("You Won!!!");
              }
              else
              {
                  numberOfGuesses++;
                  charLenght = 0;
                  currentGuess = "";
              }
          }  
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

    void CreateCorrectWord()
    {
        correctWord = _wordList.Words[Random.Range(0, _wordList.Words.Length)];
        Debug.Log(correctWord);
    }

    void UpdateBox(string a)
    {
        if (charLenght < 5)
        {
            UpdateGuess(numberOfGuesses).transform.GetChild(charLenght).gameObject.GetComponentInChildren<Text>().text = a;
            charLenght++; 
        }
        
    }

    public void Erase()
    {
        if (charLenght > 0)
        {
            UpdateGuess(numberOfGuesses).transform.GetChild(charLenght-1).gameObject.GetComponentInChildren<Text>().text = "";
            charLenght--;
        }

    }
    
    

}
