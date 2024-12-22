using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoinsGems : MonoBehaviour
{
    public GameObject coinDisplay;
    public GameObject gemDisplay;
    public GameObject endCoin;
    public GameObject endGem;
    public static int coinCount;
    public static int gemCount;
    public int internalCoin;
    public int internalGem;

    void Update()
    {
        internalCoin = coinCount;
        internalGem = gemCount;
        coinDisplay.GetComponent<Text>().text = "" + coinCount;
        gemDisplay.GetComponent<Text>().text = "" + gemCount;
        endCoin.GetComponent<Text>().text = "" + coinCount;
        endGem.GetComponent<Text>().text = "" + gemCount;
    }

}
