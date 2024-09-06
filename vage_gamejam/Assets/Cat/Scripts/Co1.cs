using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Co1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI o;
    [SerializeField] private Transform plane;
    private float cords;
    void Update()
    {
        o.color = Color.green;
        cords = plane.position.x;
        o.text = $"x {cords}";
    }
}
