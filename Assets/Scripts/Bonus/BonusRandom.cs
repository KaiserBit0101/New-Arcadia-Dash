using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusRandom : MonoBehaviour
{
    public int randomGen;
    public bool randomizingLoc;
    public GameObject[] mouseyLoc;
    public static int externalNumber;
    public int lastNumber;
    public static bool isRunning = false;

    void Update()
    {
        if (isRunning == false)
        {
            externalNumber = randomGen;
            if (randomizingLoc == false)
            {
                randomizingLoc = true;
                lastNumber = randomGen;
                randomGen = Random.Range(0, 4);
                if (lastNumber == randomGen)
                {
                    randomGen = Random.Range(0, 4);
                }
                StartCoroutine(MouseyDisplay());
            }
        }
        
    }

    IEnumerator MouseyDisplay()
    {
        mouseyLoc[randomGen].SetActive(true);
        yield return new WaitForSeconds(0.2f);
        mouseyLoc[randomGen].SetActive(false);
        randomizingLoc = false;
    }
}
