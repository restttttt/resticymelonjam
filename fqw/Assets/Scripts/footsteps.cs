using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioClip footstepSound;  // Assign the footstep sound in the Unity Editor
    public float stepDistance = 1.0f;  // Set the distance threshold for playing footsteps

    private Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        float distanceMoved = Vector3.Distance(transform.position, lastPosition);

        if (distanceMoved >= stepDistance)
        {
            PlayFootstepSound();
            lastPosition = transform.position;
        }
    }

    void PlayFootstepSound()
    {
        if (footstepSound != null)
        {
            AudioSource.PlayClipAtPoint(footstepSound, transform.position);
        }
    }
}
