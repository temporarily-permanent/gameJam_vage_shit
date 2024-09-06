using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    private AudioSource aud;
    [SerializeField] private AudioClip clip1;
    [SerializeField] private AudioClip clip2;
    [SerializeField] private AudioClip clip3;
    [SerializeField] private AudioClip clip4;
    [SerializeField] private AudioClip clip5;
    [SerializeField] private AudioClip clip6;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            aud.PlayOneShot(clip1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            aud.PlayOneShot(clip2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            aud.PlayOneShot(clip3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            aud.PlayOneShot(clip4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            aud.PlayOneShot(clip5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            aud.PlayOneShot(clip6);
        }
    }
}
