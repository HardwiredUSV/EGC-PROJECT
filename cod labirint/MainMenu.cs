﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void changescene(string scenename)
    {
        Application.LoadLevel(scenename); 
    }

    public void quitapp()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.LoadLevel("ESCmenu");
        }
    }
}
