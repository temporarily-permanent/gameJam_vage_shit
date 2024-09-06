using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;

public class Homer : MonoBehaviour
{
    [SerializeField] private Transform rok;
    [SerializeField] private int speed;

    
    private AudioSource ad;
    [SerializeField] private AudioClip clip1;
    private SphereCollider col;

    private MeshRenderer mes;
    [SerializeField] Homer homer;
    private Rigidbody rb;
    void Start()
    {
        //StartCoroutine(homing());
        col = GetComponent<SphereCollider>();
        ad = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        mes = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        transform.LookAt(rok.position);
        GetComponent<ConstantForce>().force = transform.forward * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        ad.Stop();
        ad.PlayOneShot(clip1);
        homer.enabled = false;
        mes.enabled = false;
        rb.useGravity = true;
    }
    //IEnumerator homing()
    //{
    //    transform.LookAt(rok.position);
    //    yield return new WaitForSeconds(0.1f);
    //    StartCoroutine(homing());
    //}
}
