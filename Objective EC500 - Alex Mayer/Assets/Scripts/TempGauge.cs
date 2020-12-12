using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TempGauge : MonoBehaviour
{
    public TextMeshProUGUI Gauge;
    string gaugeTextValue = "";
    public int value = 0;

    public GameObject Left;
    public GameObject Right;

    public bool food2 = false;

    private void Update()
    {
        gaugeTextValue = Gauge.text;
        if (gaugeTextValue == GameObject.Find("Numbers Code").GetComponent<Numbers>().Code1Temp)
        {
            gaugeTextValue = GameObject.Find("Numbers Code").GetComponent<Numbers>().Code1Temp;
            Gauge.color = Color.green;
            food2 = true;
        }
    }
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
