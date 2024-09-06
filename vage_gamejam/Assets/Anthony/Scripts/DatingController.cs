using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DatingController : MonoBehaviour
{
    public string[] text = new string[4];
    //[SerializeField] GameObject currentDialogObject;
    [SerializeField] TMP_Text currentDialog;
    [SerializeField] GameObject beginbutton;
    [SerializeField] GameObject secondbutton;
    [SerializeField] GameObject goodButton;
    [SerializeField] GameObject badButton;
    [SerializeField] GameObject resetButton;
    [SerializeField] Sprite[] images;
    [SerializeField] Image currentImg;
    [SerializeField] Scene nextScene;
    [SerializeField] Scene beginScene;

    // Start is called before the first frame update
    void Start()
    {

        //currentDialog = currentDialogObject.GetComponent<TextMeshPro>();
        HideAllButtons();
        currentDialog.text = text[0];
        currentImg.sprite = images[0];
        beginbutton.SetActive(true);
    }

    void HideAllButtons()
    {
        beginbutton.SetActive(false);
        secondbutton.SetActive(false);
        badButton.SetActive(false);
        goodButton.SetActive(false);
        resetButton.SetActive(false);
    }

    public void SecondScene()
    {
        currentImg.sprite = images[1];
        currentDialog.text = text[1];
        HideAllButtons();
        secondbutton.SetActive(true);
    }

    public void ThirdScene() 
    {
        currentImg.sprite = images[2];
        currentDialog.text = text[2];
        HideAllButtons();
        badButton.SetActive(true);
        goodButton.SetActive(true);
    }
    public void GoodScene()
    {
        currentImg.sprite = images[3];
        currentDialog.text = text[3];
        HideAllButtons();
        resetButton.SetActive(true);
    }
    public void BadScene()
    {
        SceneManager.LoadScene("vliegendeBoot");
    }
    public void ResetGame()
    {
        SceneManager.LoadScene("IntroRoom");
    }
}
