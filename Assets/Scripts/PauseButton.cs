using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public AudioSource musicSource;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger zone is the player
        if (other.CompareTag("Player"))
        {
            // Pause the music
            if (musicSource != null)
            {
                musicSource.Pause();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object that exited the trigger zone is the player
        if (other.CompareTag("Player"))
        {
            // Resume the music
            if (musicSource != null)
            {
                musicSource.UnPause();
            }
        }
    }
}
