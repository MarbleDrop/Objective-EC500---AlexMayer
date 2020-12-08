using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGreenRed : MonoBehaviour
{
    public bool InPlace2 = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("GreenRed"))
        {
            InPlace2 = true;
        }
    }
}
