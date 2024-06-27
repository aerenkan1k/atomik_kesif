using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudioController : MonoBehaviour
{
    public AudioClip backgroundAudio;
    private AudioSource audioSource;
    private void Start() {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = backgroundAudio;
        audioSource.Play();
        audioSource.loop = true;
    }
}
