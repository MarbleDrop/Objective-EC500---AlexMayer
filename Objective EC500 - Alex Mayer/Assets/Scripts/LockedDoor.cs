using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class LockedDoor : MonoBehaviour
{
    // Used to disable interaction and enable "the Lock"
    public GameObject toDisableHovering;
    public GameObject toEnableHovering;
    
    // refrences all keys
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;
    public GameObject key5;

    // Audio for unlocking sound
    public AudioSource OpenSound;

    private void Start()
    {
        // makes sure that the object is locked when the game starts
        DisableHovering();
        // makes sure that sound is found
        OpenSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Checks to see if a key has entered the lock area and destroys the key while setting the lock to false.
        if (other.gameObject.CompareTag("key"))
        {
            Debug.Log("Collision happened");
            Destroy(key1);
            Destroy(key2);
            Destroy(key3);
            Destroy(key4);
            Destroy(key5);
            EnableHovering();
            OpenSound.Play(0);
        }
    }
    public void EnableHovering()
    {
        // Enable hovering by ensuring any IgnoreHovering components have been removed    
        foreach (IgnoreHovering ignoreHovering in toEnableHovering.GetComponentsInChildren<IgnoreHovering>())
        {
            Destroy(ignoreHovering);
        }
    }

    public void DisableHovering()
    {
        // Disable hovering by adding IgnoreHover components to the GameObject's with Colliders
        foreach (Collider coll in toDisableHovering.GetComponentsInChildren<Collider>())
        {
            coll.gameObject.AddComponent<IgnoreHovering>();
        }
    }
}
