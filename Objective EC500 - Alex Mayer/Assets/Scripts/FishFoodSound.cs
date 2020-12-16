using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishFoodSound : MonoBehaviour
{
    public AudioSource FishFood;

    public void Shake()
    {
        {
            FishFood.Play();
        }
    }
}
