using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunSequence : MonoBehaviour
{
    public GameObject bonusCam;
    public GameObject randomStart;
    public int runnerNumber;
    public GameObject[] fakeRunners;
    public GameObject[] realRunners;
    public GameObject fadeIn;
    public GameObject fadeOut;
    public GameObject collectContainer;
    public GameObject coinDisplay;
    public GameObject gemDisplay;
    public static int runnerGo;
    public GameObject pressPlay;
    public bool passedBonus;
    public int importedCoins;
    public int importedGems;
    public bool buttonPressed;

    void Start()
    {
        BonusRandom.externalNumber = 0;
        StartCoroutine(FadeClose());
    }

    void Update()
    {
        if (Input.GetButton("Jump") && buttonPressed == false)
        {
            buttonPressed = true;
            pressPlay.SetActive(false);
            runnerNumber = BonusRandom.externalNumber;
            randomStart.SetActive(false);
            fakeRunners[0].SetActive(false);
            fakeRunners[1].SetActive(false);
            fakeRunners[2].SetActive(false);
            fakeRunners[3].SetActive(false);
            realRunners[runnerNumber].SetActive(true);
            bonusCam.GetComponent<Animator>().Play("BonusCamPan");
            importedCoins = PlayerPrefs.GetInt("TotalCoins");
            importedGems = PlayerPrefs.GetInt("TotalGems");
            StartCoroutine(RunGo());
        }
    }
    public void PressGo()
    {
        pressPlay.SetActive(false);
        runnerNumber = BonusRandom.externalNumber;
        randomStart.SetActive(false);
        fakeRunners[0].SetActive(false);
        fakeRunners[1].SetActive(false);
        fakeRunners[2].SetActive(false);
        fakeRunners[3].SetActive(false);
        realRunners[runnerNumber].SetActive(true);
        bonusCam.GetComponent<Animator>().Play("BonusCamPan");
        importedCoins = PlayerPrefs.GetInt("TotalCoins");
        importedGems = PlayerPrefs.GetInt("TotalGems");
        StartCoroutine(RunGo());
    }

    IEnumerator RunGo()
    {
        yield return new WaitForSeconds(7);
        runnerNumber = runnerGo;
        fadeOut.SetActive(true);
        if (runnerNumber == 0)
        {
            coinDisplay.GetComponent<Text>().text = "1";
            importedCoins += 1;
            PlayerPrefs.SetInt("TotalCoins", importedCoins);
            passedBonus = true;
        }
        if (runnerNumber == 1)
        {
            coinDisplay.GetComponent<Text>().text = "4";
            importedCoins += 4;
            PlayerPrefs.SetInt("TotalCoins", importedCoins);
            passedBonus = true;
        }
        if (runnerNumber == 2)
        {
            gemDisplay.GetComponent<Text>().text = "1";
            importedGems += 1;
            PlayerPrefs.SetInt("TotalGems", importedGems);
            passedBonus = true;
        }
        if (runnerNumber == 3)
        {
            coinDisplay.GetComponent<Text>().text = "10";
            importedCoins += 10;
            PlayerPrefs.SetInt("TotalCoins", importedCoins);
            passedBonus = true;
        }
        yield return new WaitForSeconds(1.2f);
        collectContainer.SetActive(true);
        yield return new WaitForSeconds(2);
        collectContainer.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        BonusRandom.isRunning = false;
        SceneManager.LoadScene(1);
    }

    IEnumerator FadeClose()
    {
        yield return new WaitForSeconds(1.3f);
        fadeIn.SetActive(false);
    }
}
