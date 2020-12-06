using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoggleViewer : MonoBehaviour
{
    // Set up corisponding Markers in the scene.
    public GameObject BookShelf;
    public GameObject ConfrenceChair;
    public GameObject EntrancePot;
    public GameObject Lounge;
    public GameObject BookShelf2;

    // Set up corisponding Keys in the scene.
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;
    public GameObject key5;

    private void OnTriggerEnter(Collider other)
    {
        // Checks to see if Head collider with tag "Goggles" enters if it does it enables marker depending on which key is active.
        if (other.gameObject.CompareTag("Goggles"))
        {
            Debug.Log("Collision Worked");
            if (key1.activeInHierarchy == true)
            {
                BookShelf.SetActive(true);
            }
            else if (key2.activeInHierarchy == true)
            {
                ConfrenceChair.SetActive(true);
            }
            else if (key3.activeInHierarchy == true)
            {
                EntrancePot.SetActive(true);
            }
            else if (key4.activeInHierarchy == true)
            {
                Lounge.SetActive(true);
            }
            else if (key5.activeInHierarchy == true)
            {
                BookShelf2.SetActive(true);
            }
        }
    }

    // Checks to see if Head collider with tag "Goggles" Exits if it does it disables marker depending on which key is active.
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Goggles"))
        {
            Debug.Log("Exit Worked");
            if (key1.activeInHierarchy == true)
            {
                BookShelf.SetActive(false);
            }
            else if (key2.activeInHierarchy == true)
            {
                ConfrenceChair.SetActive(false);
            }
            else if (key3.activeInHierarchy == true)
            {
                EntrancePot.SetActive(false);
            }
            else if (key4.activeInHierarchy == true)
            {
                Lounge.SetActive(false);
            }
            else if (key5.activeInHierarchy == true)
            {
                BookShelf2.SetActive(false);
            }
        }
    }
}