using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RewardsTake : MonoBehaviour
{

    public GameObject leftChestLid;
    public GameObject midChestLid;
    public GameObject rightChestLid;
    public GameObject leftCoin;
    public GameObject leftGem;
    public GameObject midCoin;
    public GameObject midGem;
    public GameObject rightCoin;
    public GameObject rightGem;
    public GameObject leftButton;
    public GameObject midButton;
    public GameObject rightButton;
    public int genReward; //1=coin 2=gem
    public int coinValue;
    public int gemValue;
    public GameObject leftText;
    public GameObject midText;
    public GameObject rightText;
    public GameObject fadeOut;
    public GameObject fadeIn;
    public int importedCoins;
    public int importedGems;
    public int charImport;
    public int charRunCount;
    public GameObject rewardName;
    public AudioSource chestOpen;
    public AudioSource coinCollect;
    public AudioSource gemCollect;
    public GameObject leftParts;
    public GameObject midParts;
    public GameObject rightParts;
    public bool selectedChest;

    void Start()
    {
        StartCoroutine(TurnOffFade());
        charImport = RewardTrack.whichChar;
        if (charImport == 0)
        {
            rewardName.GetComponent<Text>().text = "> LUCKY RANDOM REWARD TRIGGERED! <";
        }
        if (charImport == 1)
        {
            charRunCount = RewardTrack.mouseyCount;
            rewardName.GetComponent<Text>().text = "> MOUSEY REWARD TRIGGERED! <";
            PlayerPrefs.SetInt("MouseyPlay", 0);
        }
        if (charImport == 2)
        {
            charRunCount = RewardTrack.timmyCount;
            rewardName.GetComponent<Text>().text = "> TIMMY REWARD TRIGGERED! <";
            PlayerPrefs.SetInt("TimmyPlay", 0);
        }
        if (charImport == 3)
        {
            charRunCount = RewardTrack.doozyCount;
            rewardName.GetComponent<Text>().text = "> DOOZY REWARD TRIGGERED! <";
            PlayerPrefs.SetInt("DoozyPlay", 0);
        }
        if (charImport == 4)
        {
            charRunCount = RewardTrack.claireCount;
            rewardName.GetComponent<Text>().text = "> CLAIRE REWARD TRIGGERED! <";
            PlayerPrefs.SetInt("ClairePlay", 0);
        }
        if (charImport == 5)
        {
            charRunCount = RewardTrack.bossCount;
            rewardName.GetComponent<Text>().text = "> THE BOSS REWARD TRIGGERED! <";
            PlayerPrefs.SetInt("BossPlay", 0);
        }

        importedCoins = PlayerPrefs.GetInt("TotalCoins");
        importedGems = PlayerPrefs.GetInt("TotalGems");
    }

    void Update()
    {
        //left
        if (Input.GetButton("Fire1") && selectedChest == false)
        {
            selectedChest = true;
          
            leftButton.SetActive(false);
            midButton.SetActive(false);
            rightButton.SetActive(false);
            genReward = Random.Range(1, 3);
            if (genReward == 1)
            {
                coinValue = Random.Range(50, 201);
                StartCoroutine(LeftCoin());
            }
            if (genReward == 2)
            {
                gemValue = Random.Range(2, 10);
                StartCoroutine(LeftGem());
            }
            leftChestLid.GetComponent<Animator>().enabled = true;
            StartCoroutine(BackToMenu());
        }
        //mid
        if (Input.GetButton("Jump") && selectedChest == false)
        {
            selectedChest = true;
           
            leftButton.SetActive(false);
            midButton.SetActive(false);
            rightButton.SetActive(false);
            genReward = Random.Range(1, 3);
            if (genReward == 1)
            {
                coinValue = Random.Range(50, 201);
                StartCoroutine(MidCoin());
            }
            if (genReward == 2)
            {
                gemValue = Random.Range(2, 10);
                StartCoroutine(MidGem());
            }
            midChestLid.GetComponent<Animator>().enabled = true;
            StartCoroutine(BackToMenu());
        }
        //right
        if (Input.GetButton("Fire3") && selectedChest == false)
        {
            selectedChest = true;
            
            leftButton.SetActive(false);
            midButton.SetActive(false);
            rightButton.SetActive(false);
            genReward = Random.Range(1, 3);
            if (genReward == 1)
            {
                coinValue = Random.Range(50, 201);
                StartCoroutine(RightCoin());
            }
            if (genReward == 2)
            {
                gemValue = Random.Range(2, 10);
                StartCoroutine(RightGem());
            }
            rightChestLid.GetComponent<Animator>().enabled = true;
            StartCoroutine(BackToMenu());
        }
    }

    // left

    public void OpenLeft()
    {
       
        leftButton.SetActive(false);
        midButton.SetActive(false);
        rightButton.SetActive(false);
        genReward = Random.Range(1, 3);
        if (genReward == 1)
        {
            coinValue = Random.Range(50, 201);
            StartCoroutine(LeftCoin());
        }
        if (genReward == 2)
        {
            gemValue = Random.Range(2, 10);
            StartCoroutine(LeftGem());
        }
        leftChestLid.GetComponent<Animator>().enabled = true;
        StartCoroutine(BackToMenu());
    }

    IEnumerator LeftCoin()
    {
        yield return new WaitForSeconds(0.25f);
        leftParts.SetActive(true);
        yield return new WaitForSeconds(1);
        leftCoin.SetActive(true);
        coinCollect.Play();
        leftText.GetComponent<Text>().text = coinValue + " COINS";
        importedCoins += coinValue;
        yield return new WaitForSeconds(0.5f);
        PlayerPrefs.SetInt("TotalCoins", importedCoins);
        leftText.SetActive(true);
    }
    IEnumerator LeftGem()
    {
        yield return new WaitForSeconds(0.25f);
        leftParts.SetActive(true);
        yield return new WaitForSeconds(1);
        leftGem.SetActive(true);
        gemCollect.Play();
        leftText.GetComponent<Text>().text = gemValue + " GEMS";
        importedGems += gemValue;
        PlayerPrefs.SetInt("TotalGems", importedGems);
        yield return new WaitForSeconds(0.5f);
        leftText.SetActive(true);
    }

    //mid

    public void OpenMid()
    {
       
        leftButton.SetActive(false);
        midButton.SetActive(false);
        rightButton.SetActive(false);
        genReward = Random.Range(1, 3);
        if (genReward == 1)
        {
            coinValue = Random.Range(50, 201);
            StartCoroutine(MidCoin());
        }
        if (genReward == 2)
        {
            gemValue = Random.Range(2, 10);
            StartCoroutine(MidGem());
        }
        midChestLid.GetComponent<Animator>().enabled = true;
        StartCoroutine(BackToMenu());
    }

    IEnumerator MidCoin()
    {
        yield return new WaitForSeconds(0.25f);
        midParts.SetActive(true);
        yield return new WaitForSeconds(1);
        midCoin.SetActive(true);
        coinCollect.Play();
        midText.GetComponent<Text>().text = coinValue + " COINS";
        importedCoins += coinValue;
        yield return new WaitForSeconds(0.5f);
        PlayerPrefs.SetInt("TotalCoins", importedCoins);
        midText.SetActive(true);
    }
    IEnumerator MidGem()
    {
        yield return new WaitForSeconds(0.25f);
        midParts.SetActive(true);
        yield return new WaitForSeconds(1);
        midGem.SetActive(true);
        gemCollect.Play();
        midText.GetComponent<Text>().text = gemValue + " GEMS";
        importedGems += gemValue;
        PlayerPrefs.SetInt("TotalGems", importedGems);
        yield return new WaitForSeconds(0.5f);
        midText.SetActive(true);
    }

    //right

    public void OpenRight()
    {
        
        leftButton.SetActive(false);
        midButton.SetActive(false);
        rightButton.SetActive(false);
        genReward = Random.Range(1, 3);
        if (genReward == 1)
        {
            coinValue = Random.Range(50, 201);
            StartCoroutine(RightCoin());
        }
        if (genReward == 2)
        {
            gemValue = Random.Range(2, 10);
            StartCoroutine(RightGem());
        }
        rightChestLid.GetComponent<Animator>().enabled = true;
        StartCoroutine(BackToMenu());
    }

    IEnumerator RightCoin()
    {
        yield return new WaitForSeconds(0.25f);
        rightParts.SetActive(true);
        yield return new WaitForSeconds(1);
        rightCoin.SetActive(true);
        coinCollect.Play();
        rightText.GetComponent<Text>().text = coinValue + " COINS";
        importedCoins += coinValue;
        yield return new WaitForSeconds(0.5f);
        PlayerPrefs.SetInt("TotalCoins", importedCoins);
        rightText.SetActive(true);
    }
    IEnumerator RightGem()
    {
        yield return new WaitForSeconds(0.25f);
        rightParts.SetActive(true);
        yield return new WaitForSeconds(1);
        rightGem.SetActive(true);
        gemCollect.Play();
        rightText.GetComponent<Text>().text = gemValue + " GEMS";
        importedGems += gemValue;
        PlayerPrefs.SetInt("TotalGems", importedGems);
        yield return new WaitForSeconds(0.5f);
        rightText.SetActive(true);
    }

    IEnumerator BackToMenu()
    {
        chestOpen.Play();
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        DoozyTrack.isOn = false;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }

    IEnumerator TurnOffFade()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
