using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows;

public class MainMenu : MonoBehaviour
{
    public Text Best;
    private void Start()
    {
        NameHolder.Instance.LoadBest();
        Best.text = "Best : " + NameHolder.Instance.PreName + " : " + NameHolder.Instance.PreScore;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        if (Application.isEditor)
        {
            EditorApplication.ExitPlaymode();
        }
        else
        {
            Application.Quit();
        }
    }

    public void NewName(string name) { 
        NameHolder.Instance.Name = name;
        Debug.Log(name);
    }
}
