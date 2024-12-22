using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    public AudioSource collideCoin;

    void OnTriggerEnter(Collider other)
    {
        collideCoin.Play();
        this.gameObject.SetActive(false);
        GlobalCoinsGems.coinCount += 1;
    }

}
