using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreDisplay;
    public GameObject endScore;
    public int myScore = 0;
    public bool addingScore = false;
    public static bool preventAdding = false;
    public float increaseToSpeed = 0.4f;
    public static int distanceLookUp; //used to transfer data to PlayerPref
    public float timeValue = 1;

    void Update()
    {
        distanceLookUp = myScore;
        if (preventAdding == false)
        {
            if (addingScore == false)
            {
                StartCoroutine(AddToScore());
                addingScore = true;
            }
        }
    }

    IEnumerator AddToScore()
    {
        //speed increase relative to player actual speed increase
        if (increaseToSpeed < 0.08)
        {
            increaseToSpeed = 0.08f;
        }
        else
        {
            increaseToSpeed -= 0.0004f;
        }
        myScore += 1;
        scoreDisplay.GetComponent<Text>().text = "" + myScore.ToString("#,#") + "m";
        endScore.GetComponent<Text>().text = "" + myScore.ToString("#,#") + "m";
        yield return new WaitForSeconds(increaseToSpeed / timeValue);
        timeValue += 0.0004f;
        addingScore = false;
    }
}
