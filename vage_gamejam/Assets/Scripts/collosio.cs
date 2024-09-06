using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collosio : MonoBehaviour
{
    private SphereCollider col;
    [SerializeField] private Canvas canvas;
    private AudioSource ad;
    [SerializeField] private AudioClip clip1;

    [SerializeField] private string End = "End";
    void Start()
    {
        col = GetComponent<SphereCollider>();
        ad = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Finish")
        {

            SceneManager.LoadScene(End);
        }
        else
        {
            canvas.enabled = true;
            ad.PlayOneShot(clip1);
        }
    }
}
