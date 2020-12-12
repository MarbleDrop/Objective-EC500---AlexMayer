using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberViewer : MonoBehaviour
{
    [SerializeField]
    Text codeText;
    string codeTextValue = "";

    private void Update()
    {
        //Debug.Log(GameObject.Find("Numbers Code").GetComponent<Numbers>().Code1Temp + GameObject.Find("Numbers Code").GetComponent<Numbers>().Code2Food);
        codeText.text = codeTextValue;

        if(codeTextValue == GameObject.Find("Numbers Code").GetComponent<Numbers>().Code1Temp + GameObject.Find("Numbers Code").GetComponent<Numbers>().Code2Food)
        {
            Numbers.Temp = true;
            Numbers.Food = true;
            // Debug.Log("Code Worked");
            codeTextValue = GameObject.Find("Numbers Code").GetComponent<Numbers>().Code1Temp + GameObject.Find("Numbers Code").GetComponent<Numbers>().Code2Food;
            codeText.color = Color.green;
        }
        else if(codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }
    public void AddDigit(string digit)
    {
        if(Numbers.Temp == false)
        {
            codeTextValue += digit;
        }
    }
}
