using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FishFood : MonoBehaviour
{
    public TextMeshProUGUI Food;
    public string foodTextValue = "";

    private void Update()
    {
        if (GameObject.Find("Temp Gauge").GetComponent<TempGauge>().food2 == true)
        {
            foodTextValue = GameObject.Find("Numbers Code").GetComponent<Numbers>().Code2Food;
            Food.text = foodTextValue;
            Food.color = Color.green;
        }
    }
}
