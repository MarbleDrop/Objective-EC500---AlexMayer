using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Target;

    void Update()
    {
        // Makes the fish look at the player while only rotating on the y axis.

        Vector3 targetPosition = new Vector3(Target.transform.position.x, transform.position.y, Target.transform.position.z);
        transform.LookAt(targetPosition);
    }
}
