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
    public int numberOfGuesses;
    public int charLenght;
    private WordList _wordList;
    [SerializeField] private GameObject testBox;
    private ChangeBoxColor _changeBoxColor;
    private Colormanager _colormanager;
    [SerializeField] private GameObject Victory;
    [SerializeField] private GameObject GameOver;
    
    
    void Start()
    {
        _wordList = GameObject.Find("GameManager").GetComponent<WordList>();
        _colormanager = GameObject.Find("GameManager").GetComponent<Colormanager>();
        _changeBoxColor = testBox.GetComponent<ChangeBoxColor>();
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
              //_changeBoxColor.CheckWord();
              _colormanager.ChangeColor(numberOfGuesses);
              if (currentGuess == correctWord)
              {
                  Debug.Log("You Won!!!");
                  //Victory = GameObject.Find("Victory");
                  Victory.SetActive(true);
              }
              else
              {
                  numberOfGuesses++;
                  charLenght = 0;
                  currentGuess = "";
                  if (numberOfGuesses > 4)
                  {
                      GameOver.GetComponent<Text>().text = "Game Over " + "Correct word was: " + correctWord;
                      GameOver.SetActive(true);
                  }
              }
          }

        }
        Debug.Log("apa");
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
        if(guess == 4)
        {
            return GameObject.Find("Word5");
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
            currentGuess = currentGuess.Remove(currentGuess.Length - 1);
        }

    }
    
    

}
