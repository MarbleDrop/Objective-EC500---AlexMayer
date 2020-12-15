using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FishFood : MonoBehaviour
{
    // refrences the text on the fish food bottle
    public TextMeshProUGUI Food;
    public string foodTextValue = "";

    private void Update()
    {
        // Links to a different set of code on the temp gauge and detects if food2 should be true. if true sets the text to the second half of 4 digit code.
        if (GameObject.Find("Temp Gauge").GetComponent<TempGauge>().food2 == true)
        {
            foodTextValue = GameObject.Find("Numbers Code").GetComponent<Numbers>().Code2Food;
            Food.text = foodTextValue;
            Food.color = Color.green;
        }
    }
}
