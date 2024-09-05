using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraController : MonoBehaviour
{
    [SerializeField] public GameObject cam1;
    [SerializeField] public GameObject StartButton;
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("asdgiuasdgyugdsi");
    }
    public void SwitchCamera()
    {
        cam1.SetActive(false);
        StartButton.SetActive(false);
    }
}
