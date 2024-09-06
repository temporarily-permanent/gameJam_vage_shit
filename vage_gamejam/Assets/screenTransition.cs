using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitTime());
    }
    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(8f);
        Debug.Log("load next scene");
        SceneManager.LoadScene("");
    }
}
