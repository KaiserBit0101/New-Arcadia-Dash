using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeRandom : MonoBehaviour
{
    // chooses from 3 objects to randomly generate in a specific spot

    public GameObject object01;
    public GameObject object02;
    public GameObject object03;

    void Start()
    {
        int randomNum;
        randomNum = Random.Range(1, 4);
        if (randomNum == 1)
        {
            object01.SetActive(true);
            object02.SetActive(false);
            object03.SetActive(false);
        }
        if (randomNum == 2)
        {
            object01.SetActive(false);
            object02.SetActive(true);
            object03.SetActive(false);
        }
        if (randomNum == 3)
        {
            object01.SetActive(false);
            object02.SetActive(false);
            object03.SetActive(true);
        }
    }

}
