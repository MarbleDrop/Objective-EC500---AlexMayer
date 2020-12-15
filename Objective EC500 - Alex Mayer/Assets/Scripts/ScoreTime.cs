using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTime : MonoBehaviour
{
    public TextMeshProUGUI TimeScore;
    public string TimeScoreValue = "";
    void Start()
    {
        if (GameObject.Find("GameClockCode").GetComponent<DigitalClockSystem>().timer != 15.00f)
        {
            TimeScoreValue = GameObject.Find("GameClockCode").GetComponent<DigitalClockSystem>().TimerValue;
        }
        else if (GameObject.Find("GameClockCode").GetComponent<DigitalClockSystem>().timer == 15.00f)
        {
            TimeScoreValue = "INCOMPLETE";
        }
    }

    private void Update()
    {
        TimeScore.text = TimeScoreValue;
    }
}
