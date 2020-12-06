using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMarker : MonoBehaviour
{
    public Vector3 RotateSpeed;
    
    void Update()
    {
        this.transform.Rotate(RotateSpeed * Time.deltaTime);
    }
}
