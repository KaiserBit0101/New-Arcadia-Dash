using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGem : MonoBehaviour
{
    public AudioSource gemSound;

    void OnTriggerEnter(Collider other)
    {
        gemSound.Play();
        this.gameObject.SetActive(false);
    }

}
