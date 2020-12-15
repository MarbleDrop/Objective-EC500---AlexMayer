using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DigitalClockSystem : MonoBehaviour
{
    // links to text.
    public TextMeshProUGUI textTimer;
    public GameObject GameClock;

    // sets up the timer
    public float timer = 0.0f;
    public bool isTimer = true;
    public string TimerValue = "";

    // Ends game if 15 minutes is reached.
    public bool min15 = false;
    public bool LoadLevel = false;
    public GameObject Load;

    // Objects to be destroyed When winning.
    public GameObject FiishFood;
    public GameObject TempGauge;
    public GameObject FishTank;
    public GameObject Chest;
    public GameObject TempNumber;
    public GameObject Left;
    public GameObject Right;

    // calls bot functions if requirements are met.
    void Update()
    {
        TimerValue = textTimer.text;
        if (isTimer)
        {
            timer += Time.deltaTime;
            DisplayTime();
        }

        if (TimerValue == "15:00")
        {
            GameOver();
        }
    }

    // sets the time.
    void DisplayTime()
    {
        int minutes = Mathf.FloorToInt(timer / 60.0f);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // if called ends the game and brings the player to the main menue.
    void GameOver()
    {
        bool LoadLevel = true;
        if (LoadLevel == true)
        {
            Load.SetActive(true);
            Debug.Log("You Loose");
            DestroyObject(FiishFood);
            DestroyObject(TempGauge);
            DestroyObject(FishTank);
            DestroyObject(Chest);
            DestroyObject(TempNumber);
            DestroyObject(Left);
            DestroyObject(Right);
        }
    }
}
