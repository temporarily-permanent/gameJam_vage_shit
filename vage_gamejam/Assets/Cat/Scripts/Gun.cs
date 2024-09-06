using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private AudioSource audi;
    [SerializeField] private AudioClip brrt;
    [SerializeField] GameObject bullet;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audi.PlayOneShot(brrt);
            Destroy(Instantiate(bullet, transform.position, transform.rotation), 20);
        }
    }
}
