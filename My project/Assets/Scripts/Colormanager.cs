using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colormanager : MonoBehaviour
{
    [SerializeField] public GameObject word1Box1;
    [SerializeField] public GameObject word1Box2;
    [SerializeField] public GameObject word1Box3;
    [SerializeField] public GameObject word1Box4;
    [SerializeField] public GameObject word1Box5;
    
    [SerializeField] public GameObject word2Box1;
    [SerializeField] public GameObject word2Box2;
    [SerializeField] public GameObject word2Box3;
    [SerializeField] public GameObject word2Box4;
    [SerializeField] public GameObject word2Box5;
    
    [SerializeField] public GameObject word3Box1;
    [SerializeField] public GameObject word3Box2;
    [SerializeField] public GameObject word3Box3;
    [SerializeField] public GameObject word3Box4;
    [SerializeField] public GameObject word3Box5;
    
    [SerializeField] public GameObject word4Box1;
    [SerializeField] public GameObject word4Box2;
    [SerializeField] public GameObject word4Box3;
    [SerializeField] public GameObject word4Box4;
    [SerializeField] public GameObject word4Box5;
    
    [SerializeField] public GameObject word5Box1;
    [SerializeField] public GameObject word5Box2;
    [SerializeField] public GameObject word5Box3;
    [SerializeField] public GameObject word5Box4;
    [SerializeField] public GameObject word5Box5;
    
    [SerializeField] public GameObject keyboardA;
    private ChangeBoxColor _changeBoxColor;

    private void Start()
    {
        _changeBoxColor = GameObject.Find("GameManager").GetComponent<ChangeBoxColor>();
    }

    public void ChangeColor(int i)
    {
        if (i == 0)
        {
            _changeBoxColor = word1Box1.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word1Box2.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word1Box3.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word1Box4.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word1Box5.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = keyboardA.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
        }
        if (i == 1)
        {
            _changeBoxColor = word2Box1.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word2Box2.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word2Box3.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word2Box4.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word2Box5.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
        }
        if (i == 2)
        {
            _changeBoxColor = word3Box1.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word3Box2.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word3Box3.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word3Box4.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word3Box5.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
        }
        if (i == 3)
        {
            _changeBoxColor = word4Box1.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word4Box2.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word4Box3.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word4Box4.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word4Box5.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
        }
        if (i == 4)
        {
            _changeBoxColor = word5Box1.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word5Box2.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word5Box3.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word5Box4.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
            _changeBoxColor = word5Box5.GetComponent<ChangeBoxColor>();
            _changeBoxColor.CheckWord();
        }
    }
    

}
