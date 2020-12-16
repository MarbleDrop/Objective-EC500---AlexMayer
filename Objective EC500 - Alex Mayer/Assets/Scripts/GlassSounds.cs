using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassSounds : MonoBehaviour
{
    public AudioSource GlassBreak;
    public AudioSource pickUp;
    public AudioSource drop;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 8)
        {
            GlassBreak.Play();
        }
    }

    public void PickUp()
    {
        pickUp.Play();
    }

    public void Drop()
    {
        drop.Play();
    }
}
