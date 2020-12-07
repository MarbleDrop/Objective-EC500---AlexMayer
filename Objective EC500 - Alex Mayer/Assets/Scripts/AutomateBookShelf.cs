using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomateBookShelf : MonoBehaviour
{
    // Finds Both doors needing to open.
    public GameObject Left;
    public GameObject Right;

    // Sets the direction and speed of opening/closing.
    public Vector3 OpenSpeedL;
    public Vector3 OpenSpeedR;

    public Vector3 CloseSpeedL;
    public Vector3 CloseSpeedR;

    // Sets the distance the door can travel.
    public float distanceTraveled = 0;

    // Detects if Trophy is in box collider and if it has entered or exited the area.
    public bool entered = false;
    public bool exit = false;

    // For the sound to play.
    public AudioSource OpenSound;

    private void Start()
    {
        OpenSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        // If the Trophy enters the desk trigger the doors will open and stop at a certain distance displaced.
        if (other.gameObject.CompareTag("Trophy"))
        {
            exit = false;
            entered = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // If the Trophy exits the desk trigger the doors will close and stop at the starting point.
        if (other.gameObject.CompareTag("Trophy"))
        {
            entered = false;
            exit = true;
        }
    }
    // Update is where the code is for door opening as Time.deltaTime did not work in the on trigger enter/exit.
    private void Update()
    {
        if (entered == true)
        {
            if (distanceTraveled < 25f)
            {
                Left.transform.Translate(OpenSpeedL * Time.deltaTime);
                Right.transform.Translate(OpenSpeedR * Time.deltaTime);
                distanceTraveled += 5f * Time.deltaTime;
            }
            if (distanceTraveled < 2f)
            {
                OpenSound.Play(0);
            }
        }

        if (exit == true)
        {
            if (distanceTraveled > 0f)
            {
                Left.transform.Translate(CloseSpeedL * Time.deltaTime);
                Right.transform.Translate(CloseSpeedR * Time.deltaTime);
                distanceTraveled -= 5f * Time.deltaTime;
            }
            if (distanceTraveled > 15f)
            {
                OpenSound.Play(0);
            }
        }
    }
}