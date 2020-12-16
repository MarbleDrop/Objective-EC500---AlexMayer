using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMoveSound : MonoBehaviour
{
    public AudioSource DoorSound;
    
    public void Opening()
    {
        DoorSound.Play();
    }
    
}