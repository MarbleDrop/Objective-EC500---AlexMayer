using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool loadLevel = false;
    public GameObject Load;
    
    // Linked to the play button starts the game by setting load to true.
    public void PlayGame()
    {
        bool loadLevel = true;
        if(loadLevel == true)
        {
            Load.SetActive(true);
            Debug.Log("Button was clicked");
        }
    }

    // Quits the game if quit button is pressed.
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
