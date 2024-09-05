using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cameraController : MonoBehaviour
{
    public GameObject cam1;
    public GameObject StartButton;
    public Scene NextScene;
    // Start is called before the first frame update
    private void Start()
    {
        //Debug.Log("asdgiuasdgyugdsi");
    }
    public void SwitchCamera()
    {
        cam1.SetActive(false);
        StartButton.SetActive(false);
        SceneManager.LoadScene(NextScene.ToString());
    }
}
