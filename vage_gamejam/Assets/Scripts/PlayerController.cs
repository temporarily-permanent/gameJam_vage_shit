using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Canvas canvas;
    private Rigidbody rb;
    private ConstantForce cf;
    private AudioSource au;
    [SerializeField] private TextMeshProUGUI SpeedMeter;
    [SerializeField] private GameObject plane;
    [SerializeField] private AudioClip clip1; //boost1
    [SerializeField] private AudioClip clip2; //alarm
    [SerializeField] private AudioClip clip3; //explosion
    [SerializeField] private AudioClip clip4; //boost2
    [SerializeField] private AudioClip clip;  //death

    [SerializeField] private double speed;
    private int rott;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        cf = gameObject.GetComponent<ConstantForce>();
        au = gameObject.GetComponent<AudioSource>();
        StartCoroutine(checkGForce());

        rb.velocity = new Vector3();
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.CapsLock)) 
        {
            GetComponent<ConstantForce>().force = transform.forward * 1000;
            au.PlayOneShot(clip1);
        }
        else if(Input.GetKey(KeyCode.Space))
        {
            GetComponent<ConstantForce>().relativeForce = new Vector3(0, 0, 3000);
            GetComponent<ConstantForce>().force = transform.forward * 3000;
            au.PlayOneShot(clip4);
        }
        else
        {
            GetComponent<ConstantForce>().relativeForce = new Vector3(0, 0, 5);
            GetComponent<ConstantForce>().force = transform.forward * 0;
        }
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            rott = 3;
        }
        else
        {
            rott = 1;
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            plane.transform.Rotate(1 * rott, 0, 0);
        }
        if (Input.GetKey(KeyCode.Keypad8))
        {
            plane.transform.Rotate(-1 * rott, 0, 0);
        }

        if (Input.GetKey(KeyCode.Keypad7))
        {
            plane.transform.Rotate(0, 0, 4 * rott);
        }
        if (Input.GetKey(KeyCode.Keypad9))
        {
            plane.transform.Rotate(0, 0, -4 * rott);
        }

        speed = rb.velocity.magnitude;
    }
    IEnumerator checkGForce()
    {
        if (speed > 6000)
        {
            au.PlayOneShot(clip2);
            SpeedMeter.color = Color.red;
        }
        else
        {
            SpeedMeter.color = Color.white;
        }
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(checkGForce());

    }
    private void Update()
    {
        if (speed > 9000)
        {
            au.PlayOneShot(clip3);
            canvas.enabled = true;
            au.PlayOneShot(clip);
        }
        SpeedMeter.text = $"{speed}";
    }
}