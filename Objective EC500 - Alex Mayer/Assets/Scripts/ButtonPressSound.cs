using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressSound : MonoBehaviour
{
    public AudioSource Press;

    public void pressed()
    {
        Press.Play();
    }
}
