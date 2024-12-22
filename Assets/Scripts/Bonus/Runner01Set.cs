using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner01Set : MonoBehaviour
{

    void Start()
    {
        BonusRandom.isRunning = true;
        StartCoroutine(PassNumber());
    }

    IEnumerator PassNumber()
    {
        yield return new WaitForSeconds(1);
        RunSequence.runnerGo = 0;
    }

}
