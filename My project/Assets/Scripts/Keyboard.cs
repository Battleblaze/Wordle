using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    private GameObject box1;
    // Start is called before the first frame update
    void Start()
    {
        box1 = GameObject.Find("Word1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressQ()
    {
        box1.GetComponent<Text>().text = "Q";
    }
}
