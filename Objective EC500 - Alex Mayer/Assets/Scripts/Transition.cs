using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Transition : MonoBehaviour
{
    public AudioMixerSnapshot transition;
    public AudioMixerSnapshot transitionBack;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        transition.TransitionTo(0.9f);
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        transitionBack.TransitionTo(0.9f);
    }
}