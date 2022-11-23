using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeBoxColor : MonoBehaviour
{
    Image panel;
    
    // Start is called before the first frame update
    void Start()
    {
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
    
    
    
}
