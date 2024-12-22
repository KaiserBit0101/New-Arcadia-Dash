using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollision : MonoBehaviour
{
    public AudioSource collideGem;

    void OnTriggerEnter(Collider other)
    {
        collideGem.Play();
        this.gameObject.SetActive(false);
        GlobalCoinsGems.gemCount += 1;
    }

}
