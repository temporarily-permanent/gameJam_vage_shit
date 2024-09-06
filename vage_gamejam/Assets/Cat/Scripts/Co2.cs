using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Co2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI o;
    [SerializeField] private Transform plane;
    private float cords;
    void Update()
    {
        o.color = Color.red;
        cords = plane.position.y;
        o.text = $"y {cords}";
    }
}
