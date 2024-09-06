using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Co3 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI o;
    [SerializeField] private Transform plane;
    private float cords;
    void Update()
    {
        o.color = Color.cyan;
        cords = plane.position.z;
        o.text = $"z {cords}";
    }
}
