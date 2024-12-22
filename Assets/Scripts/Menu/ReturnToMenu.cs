using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    public GameObject continueButton;
    public GameObject fadeOut;
    public int randomReward;
    public bool buttonPressed;

    void Update()
    {
        if (Input.GetButton("Jump") && buttonPressed == false)
        {
            if (ObjectCollision.pressToContinue == true || ManholeDrop.canEnd == true)
            {
                ManholeDrop.canEnd = false;
                ObjectCollision.pressToContinue = false;
                continueButton.SetActive(false);
                StartCoroutine(ReturnToMainMenu());
            }
        }
    }
    public void ContinueButton()
    {
        ObjectCollision.pressToContinue = false;
        continueButton.SetActive(false);
        StartCoroutine(ReturnToMainMenu());
    }

    IEnumerator ReturnToMainMenu()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        if (RewardTrack.timmyCount == 7 || RewardTrack.mouseyCount == 7 || RewardTrack.doozyCount == 7 || RewardTrack.claireCount == 7 || RewardTrack.bossCount == 7)
        {
            if (RewardTrack.timmyCount == 7)
            {
                RewardTrack.whichChar = 2;
                SceneManager.LoadScene(13);
            }
           
            if (RewardTrack.mouseyCount == 7)
            {
                RewardTrack.whichChar = 1;
                SceneManager.LoadScene(13);
            }
            
            if (RewardTrack.doozyCount == 7)
            {
                RewardTrack.whichChar = 3;

            }
            
            if (RewardTrack.claireCount == 7)
            {
                RewardTrack.whichChar = 4;
                SceneManager.LoadScene(13);
            }
            
            if (RewardTrack.bossCount == 7)
            {
                RewardTrack.whichChar = 5;
                SceneManager.LoadScene(13);
            }

        }
        else
        {
            randomReward = Random.Range(1, 51);
            if (randomReward > 45)
            {
                RewardTrack.whichChar = 0;
                SceneManager.LoadScene(13);
            }
            else
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
