using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeBoxColor : MonoBehaviour
{
    private Game _game;
    private Colormanager _colormanager;
    Image panel;
    private char a;
    
    // Start is called before the first frame update
    void Start()
    {
        _game = GameObject.Find("GameManager").GetComponent<Game>();
        _colormanager = GameObject.Find("GameManager").GetComponent<Colormanager>();
        panel = GetComponent<Image>();
    }
    

    public void CheckWord()
    {
        
            if (_game.correctWord.Contains(gameObject.GetComponentInChildren<Text>().text))
            {
                ChangeToYellow();
            }
            else
            {
                ChangeToGray();
            }

            for (int j = 0; j < _game.correctWord.Length; j++)
            {
                if (gameObject.name == "1")
                {
                    if (_game.correctWord.IndexOf(gameObject.GetComponentInChildren<Text>().text) == 0)
                    {
                        ChangeToGreen();
                    }
                }
                if (gameObject.name == "2")
                {
                    if (_game.correctWord.IndexOf(gameObject.GetComponentInChildren<Text>().text) == 1)
                    {
                        ChangeToGreen();
                    }
                }
                if (gameObject.name == "3")
                {
                    if (_game.correctWord.IndexOf(gameObject.GetComponentInChildren<Text>().text) == 2)
                    {
                        ChangeToGreen();
                    }
                }
                if (gameObject.name == "4")
                {
                    if (_game.correctWord.IndexOf(gameObject.GetComponentInChildren<Text>().text) == 3)
                    {
                        ChangeToGreen();
                    }
                }
                if (gameObject.name == "5")
                {
                    if (_game.correctWord.IndexOf(gameObject.GetComponentInChildren<Text>().text) == 4)
                    {
                        ChangeToGreen();
                    }
                }
            }
        

    }

    public void ChangeToYellow()
    {
        panel.color = Color.yellow;
    }
    public void ChangeToGreen()
    { 
        panel.color = Color.green;
    }
    public void ChangeToGray()
    {
        panel.color = Color.gray;
    }



}
