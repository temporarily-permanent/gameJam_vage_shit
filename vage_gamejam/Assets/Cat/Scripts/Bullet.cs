using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class travel : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine(hom());
    }
    void Update()
    {
        GetComponent<ConstantForce>().force = transform.forward * 1000;
    }
    //IEnumerator hom()
    //{
    //    yield return new WaitForSeconds(5f);
    //    Destroy(gameObject);
    //    StartCoroutine(hom());
    //}
}
