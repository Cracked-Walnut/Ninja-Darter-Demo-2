﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadLevel(int _loadIndex) {
        
      SceneManager.LoadScene(_loadIndex);
      if (Time.timeScale == 0)
        Time.timeScale = 1;  
    }

    public void LoadLevel(string _levelName) {

      SceneManager.LoadScene(_levelName);
      if (Time.timeScale == 0)
        Time.timeScale = 1;
    }

    public void Quit() {
      Application.Quit();
    }
}
