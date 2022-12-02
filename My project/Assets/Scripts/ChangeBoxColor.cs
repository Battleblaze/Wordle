using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeBoxColor : MonoBehaviour
{
    private Game _game;
    Image panel;
    private char a;
    
    // Start is called before the first frame update
    void Start()
    {
        _game = GameObject.Find("GameManager").GetComponent<Game>();
        panel = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            panel.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            panel.color = Color.gray;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            panel.color = Color.green;
        }
    }

    public void CheckWord()
    {
        if (_game.currentGuess.Contains(gameObject.GetComponentInChildren<Text>().text))
        {
            ChangeToYellow();
            
        }

        for (int i = 0; i < _game.currentGuess.Length; i++)
        {
            if ()
            {
            
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
    public void ChangeToGray(GameObject currentBox)
    {
        panel.color = Color.gray;
    }



}
