using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip collectSound;
    public static Collect Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Desk"))
        {
            Destroy(collision.gameObject);
            audioSource.PlayOneShot(collectSound);
        }


    }

}
