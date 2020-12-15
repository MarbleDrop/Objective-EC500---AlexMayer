using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TempGauge : MonoBehaviour
{
    // links the temperature gauge to the text.
    public TextMeshProUGUI Gauge;
    string gaugeTextValue = "";
    public int value = 0;

    // sets the buttons for left and right.
    public GameObject Left;
    public GameObject Right;

    // for the fish food code.
    public bool food2 = false;

    public GameObject Hungry;
    public GameObject Cold;

    private void Update()
    {
        // finds the numbers for the code and if imput correctly sets it to green and disables buttons.
        gaugeTextValue = Gauge.text;
        if (gaugeTextValue == GameObject.Find("Numbers Code").GetComponent<Numbers>().Code1Temp)
        {
            gaugeTextValue = GameObject.Find("Numbers Code").GetComponent<Numbers>().Code1Temp;
            Gauge.color = Color.green;
            food2 = true;
        }
        if (food2 == true)
        {
            Hungry.SetActive(true);
            Cold.SetActive(false);
        }
    }
    // sets up both buttons to add or subtract from the number.
    public void LeftButton()
    {
        if (gaugeTextValue != GameObject.Find("Numbers Code").GetComponent<Numbers>().Code1Temp)
        {
            value--;
            Gauge.text = value.ToString();
        }
    }
    public void RightButton()
    {
        if (gaugeTextValue != GameObject.Find("Numbers Code").GetComponent<Numbers>().Code1Temp)
        {
            value++;
            Gauge.text = value.ToString();
        }
    }
}
