using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MashAbility : MonoBehaviour
{

    public GameObject theCamera;
    public GameObject leftArrow;
    public GameObject rightArrow;
    public GameObject realLeft;
    public GameObject realRight;
    public GameObject playButton;
    public GameObject realPlay;
    public GameObject stageTitle;
    public AudioSource startPress;
    public GameObject fadeOut;
    public GameObject loadText;
    public static bool showSpecial = true;
    public bool pressingButton;
    public bool movingBackRight;
    public static bool onSpecial;

    public bool internalShowSpecial;
    public bool internalOnSpecial;

    void Start()
    {
        showSpecial = true;
    }

    void Update()
    {
        internalOnSpecial = onSpecial;
        internalShowSpecial = showSpecial;
        

        if (Input.GetButton("LBButton") && pressingButton == false && showSpecial == true)
        {
            pressingButton = true;
            showSpecial = false;
            theCamera.GetComponent<Animator>().Play("DesertToMash");
            realRight.SetActive(false);
            realPlay.SetActive(false);
            stageTitle.SetActive(false);
            leftArrow.SetActive(false);
            onSpecial = true;
            StartCoroutine(MoveToMash());
        }

        if (Input.GetButton("RBButton") && pressingButton == false && showSpecial == false && movingBackRight == true )
        {
            pressingButton = true;
            theCamera.GetComponent<Animator>().Play("MashToDesert");
            realRight.SetActive(false);
            realPlay.SetActive(false);
            playButton.SetActive(false);
            stageTitle.SetActive(false);
            rightArrow.SetActive(false);
            StartCoroutine(MoveToDesert());
        }

        if (Input.GetButton("Jump") && pressingButton == false && onSpecial == true)
        {
            pressingButton = true;
            startPress.Play();
            playButton.SetActive(false);
            leftArrow.SetActive(false);
            rightArrow.SetActive(false);
            StartCoroutine(PlayStage());
        }
    }


    public void LeftPress()
    {
        showSpecial = false;
        theCamera.GetComponent<Animator>().Play("DesertToMash");
        realRight.SetActive(false);
        realPlay.SetActive(false);
        stageTitle.SetActive(false);
        leftArrow.SetActive(false);
        StartCoroutine(MoveToMash());
    }

    public void RightPress()
    {
        theCamera.GetComponent<Animator>().Play("MashToDesert");
        realRight.SetActive(false);
        realPlay.SetActive(false);
        playButton.SetActive(false);
        stageTitle.SetActive(false);
        rightArrow.SetActive(false);
        StartCoroutine(MoveToDesert());
    }

    public void StartMash()
    {
        startPress.Play();
        playButton.SetActive(false);
        leftArrow.SetActive(false);
        rightArrow.SetActive(false);
        StartCoroutine(PlayStage());
    }

    IEnumerator MoveToMash()
    {
        yield return new WaitForSeconds(1);
        stageTitle.GetComponent<Text>().text = "?????????????????";
        stageTitle.SetActive(true);
        rightArrow.SetActive(true);
        playButton.SetActive(true);
        pressingButton = false;
        movingBackRight = true;
        onSpecial = true;
    }

    IEnumerator PlayStage()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        loadText.SetActive(true);
        SceneManager.LoadScene(10);
    }

    IEnumerator MoveToDesert()
    {
        yield return new WaitForSeconds(1);
        stageTitle.GetComponent<Text>().text = "DESERT DREAMS";
        stageTitle.SetActive(true);
        realRight.SetActive(true);
        realPlay.SetActive(true);
        leftArrow.SetActive(true);
        showSpecial = true;
        movingBackRight = false;
        onSpecial = false;
        pressingButton = false;
    }

}
