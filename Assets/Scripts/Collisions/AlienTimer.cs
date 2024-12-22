using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienTimer : MonoBehaviour
{
    public float randomTime;

    void Start()
    {
        randomTime = Random.Range(1, 4);
        StartCoroutine(TurnOffAlien());
    }

    IEnumerator TurnOffAlien()
    {
        yield return new WaitForSeconds(randomTime);
        this.gameObject.GetComponent<Animation>().enabled = false;
    }


}
