﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	public void NewGame()
    {
        SceneManager.LoadScene ("Day1");
    }

    public void HelpScene()
    {
        SceneManager.LoadScene("Help Scene");
    }
}
