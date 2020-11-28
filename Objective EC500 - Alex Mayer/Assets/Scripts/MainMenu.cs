using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool loadLevel = false;
    public GameObject Load;
    public void PlayGame()
    {
        bool loadLevel = true;
        if(loadLevel == true)
        {
            Load.SetActive(true);
            Debug.Log("Button was clicked");
        }
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
