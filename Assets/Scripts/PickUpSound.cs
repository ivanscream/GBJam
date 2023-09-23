using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSound : MonoBehaviour
{
    private AudioSource audioSource;
    public String[] tags;


    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        foreach (string tag in tags)
        {
            if (other.CompareTag(tag))
            {
                audioSource.Play();
                Debug.Log("Collided with" + tag);
                break;
            }

            ;
        }
    }
}
 
