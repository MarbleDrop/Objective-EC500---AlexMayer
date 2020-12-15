using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Prevents the object from being destroyed on load.
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
