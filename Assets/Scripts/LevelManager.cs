﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
         if(name=="Start")
            NumberWizard.guessCount=0;
      SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        //Debug.Log("I want to quit!");  
        Application.Quit();
    }
}
