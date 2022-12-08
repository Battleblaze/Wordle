using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ChangeBoxColor : MonoBehaviour
{
    private Game _game;
    private Colormanager _colormanager;
    Image panel;
    private char a;
    public bool isGreen = false;
    
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
                    if (char.ToString(_game.correctWord[0]) == gameObject.GetComponentInChildren<Text>().text)
                    {
                        ChangeToGreen();
                    }
                }
                
                if (gameObject.name == "2")
                {
                    if (char.ToString(_game.correctWord[1]) == gameObject.GetComponentInChildren<Text>().text)
                    {
                        ChangeToGreen();
                    }
                }
                if (gameObject.name == "3")
                {
                    if (char.ToString(_game.correctWord[2]) == gameObject.GetComponentInChildren<Text>().text)
                    {
                        ChangeToGreen();
                    }
                }
                if (gameObject.name == "4")
                {
                    
                    if (char.ToString(_game.correctWord[3]) == gameObject.GetComponentInChildren<Text>().text)
                    {
                        ChangeToGreen();
                    }
                }
                if (gameObject.name == "5")
                {
                    
                    if (char.ToString(_game.correctWord[4]) == gameObject.GetComponentInChildren<Text>().text)
                    {
                        ChangeToGreen();
                    }
                }
            }
        

    }

    public void ChangeToYellow()
    {
        panel.color = Color.yellow;
        if (isGreen == false)
        {
         GameObject key = GameObject.Find(gameObject.GetComponentInChildren<Text>().text);
                 key.GetComponent<Image>().color= Color.yellow;   
        }
          
        
        
    }
    public void ChangeToGreen()
    { 
        panel.color = Color.green;
        GameObject key = GameObject.Find(gameObject.GetComponentInChildren<Text>().text);
        key.GetComponent<Image>().color= Color.green;
        isGreen = true;


    }
    public void ChangeToGray()
    {
        panel.color = Color.gray;
        GameObject key = GameObject.Find(gameObject.GetComponentInChildren<Text>().text);
        key.GetComponent<Image>().color= Color.gray;
    }



}
