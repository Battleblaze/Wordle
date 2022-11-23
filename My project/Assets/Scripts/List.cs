using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    new public List<String> wordlist;

    private void Start()
    {
        wordlist.Add("album");
    }
}
