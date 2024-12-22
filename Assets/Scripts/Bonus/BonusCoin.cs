using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusCoin : MonoBehaviour
{
    public AudioSource coinSound;

    void OnTriggerEnter(Collider other)
    {
        coinSound.Play();
        this.gameObject.SetActive(false);
    }

}
