using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectRedBlue : MonoBehaviour
{
    public bool InPlace3 = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("RedBlue"))
        {
            InPlace3 = true;
        }
    }
}
