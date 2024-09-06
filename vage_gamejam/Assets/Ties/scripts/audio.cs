using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    AudioSource audioplay;
    // Start is called before the first frame update
    void Start()
    {
        audioplay = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioplay.Play();
    }
}
