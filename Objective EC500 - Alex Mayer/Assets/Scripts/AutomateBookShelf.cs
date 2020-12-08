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

    // Modified this script to hold 3 other detetcion scripts.
    private void Start()
    {
        OpenSound = GetComponent<AudioSource>();
    }

   // private void OnTriggerExit(Collider other)
   // {
        // If the Trophy exits the desk trigger the doors will close and stop at the starting point.
    //    if (other.gameObject.CompareTag("Trophy"))
    //    {
    //        entered = false;
    //       exit = true;
    //    }
   // }

    // Update is where the code is for door opening as Time.deltaTime did not work in the on trigger enter/exit.
    private void Update()
    {
        // If the book enters the trigger the doors will stay closed till all other books are placed. Having all books set to true.
        if (GameObject.Find("GreenBlue").GetComponent<DetectGreenBlue>().InPlace1 == true && GameObject.Find("GreenRed").GetComponent<DetectGreenRed>().InPlace2 == true && GameObject.Find("RedBlue").GetComponent<DetectRedBlue>().InPlace3 == true)
        {
            entered = true;
        }
        if (entered == true)
        {
            new WaitForSeconds(1);
            if (distanceTraveled < 6f)
            {
                Left.transform.Translate(OpenSpeedL * Time.deltaTime);
                Right.transform.Translate(OpenSpeedR * Time.deltaTime);
                distanceTraveled += 5f * Time.deltaTime;
            }
            if (distanceTraveled < 0.3f)
            {
                OpenSound.Play(0);
            }
        }

  //      if (exit == true)
  //      {
  //          if (distanceTraveled > 0f)
  //          {
  //              Left.transform.Translate(CloseSpeedL * Time.deltaTime);
  //              Right.transform.Translate(CloseSpeedR * Time.deltaTime);
  //              distanceTraveled -= 5f * Time.deltaTime;
  //          }
  //          if (distanceTraveled > 15f)
  //          {
  //              OpenSound.Play(0);
  //          }
  //      }
    }
}