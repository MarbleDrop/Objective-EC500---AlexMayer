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
        codeText.text = codeTextValue;

        if(codeTextValue == GameObject.Find("Numbers Code").GetComponent<Numbers>().Code1Temp + GameObject.Find("Numbers Code").GetComponent<Numbers>().Code2Food)
        {
            Numbers.Temp = true;
        }
        if(codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
