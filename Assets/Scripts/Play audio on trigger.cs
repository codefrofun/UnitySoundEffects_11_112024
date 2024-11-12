using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playaudioontrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip triggerSound; // The sound to play when entering the trigger zone

    // This function will be called when another collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger zone is the player 
        if (other.CompareTag("Player")) 
        {
            if (audioSource != null && triggerSound != null)
            {
                // Play the audio clip
                audioSource.PlayOneShot(triggerSound); // PlayOneShot to play the sound immediately
            }
        }
    }
}
