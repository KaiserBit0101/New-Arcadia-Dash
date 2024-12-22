using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManualCollide : MonoBehaviour
{
    public GameObject theCharacter;
    public GameObject dustParts;
    public GameObject theCamera;
    public AudioSource collideEffect;
    public GameObject footSteps;
    public GameObject fadeOut;
    public GameObject endPanel;
    public GameObject[] scoringPanels;
    //playerprefs for saving
    public int importedDistance;
    public int importedCoins;
    public int importedGems;

    void Start()
    {
            footSteps.SetActive(false);
            GlobalScore.preventAdding = true;
            //this.gameObject.GetComponent<PlayerControl>().enabled = false;
            GlobalCollisionDetect.hasCollided = true;
            //collideEffect.Play();
            
#pragma warning disable CS0618
            //dustParts.GetComponent<ParticleSystem>().startSize = 0;
#pragma warning restore CS0618
            StartCoroutine(ResetGame());

    }

    IEnumerator ResetGame()
    {
        yield return new WaitForSeconds(1);
        //obtain previous values
        importedDistance = PlayerPrefs.GetInt("TotalDistance");
        importedCoins = PlayerPrefs.GetInt("TotalCoins");
        importedGems = PlayerPrefs.GetInt("TotalGems");
        //add current values
        importedDistance += GlobalScore.distanceLookUp;
        importedCoins += GlobalCoinsGems.coinCount;
        importedGems += GlobalCoinsGems.gemCount;
        //save new values
        PlayerPrefs.SetInt("TotalDistance", importedDistance);
        PlayerPrefs.SetInt("TotalCoins", importedCoins);
        PlayerPrefs.SetInt("TotalGems", importedGems);
        //continue as normal
        endPanel.SetActive(true);
        scoringPanels[0].SetActive(false);
        scoringPanels[1].SetActive(false);
        scoringPanels[2].SetActive(false);
        scoringPanels[3].SetActive(false);
        scoringPanels[4].SetActive(false);
        scoringPanels[5].SetActive(false);
        yield return new WaitForSeconds(1);
        //SceneManager.LoadScene(0);
    }

}
