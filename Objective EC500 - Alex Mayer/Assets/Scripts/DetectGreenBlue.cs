using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGreenBlue : MonoBehaviour
{
    public bool InPlace1 = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("GreenBlue"))
        {
            InPlace1 = true;
        }
    }
}