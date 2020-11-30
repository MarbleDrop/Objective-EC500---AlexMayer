using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPosGenerator : MonoBehaviour
{
    public GameObject Key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;
    public GameObject key5;

    public int randomNum;

    void Start()
    {
        randomNum = Random.Range(1, 6);
        if (randomNum == 1)
        {
            Key1.SetActive(true);
        }
        else if(randomNum == 2)
        {
            key2.SetActive(true);
        }
        else if(randomNum == 3)
        {
            key3.SetActive(true);
        }
        else if(randomNum == 4)
        {
            key4.SetActive(true);
        }
        else
        {
            key5.SetActive(true);
        }
    }

    
}
