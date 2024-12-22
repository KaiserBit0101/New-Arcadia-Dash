using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManholeDrop : MonoBehaviour
{
    public AudioSource fallSound;
    public GameObject cameraTim;
    public GameObject cameraMou;
    public GameObject cameraDoo;
    public GameObject cameraCla;
    public GameObject cameraBos;
    public static int characterNumber;
    public int internalChar;
    public GameObject manualCollide;
    public static bool inManhole;
    public static bool canEnd;

    void Update()
    {
        internalChar = characterNumber;
    }

    void OnTriggerEnter(Collider other)
    {
        manualCollide.SetActive(true);
        inManhole = true;
        canEnd = true;
        other.GetComponent<ObjectCollision>().enabled = false;
        other.GetComponent<PlayerControl>().enabled = false;
        other.GetComponent<Rigidbody>().useGravity = true;
        fallSound.Play();
        if (characterNumber == 1)
        {
            cameraMou.transform.parent = null;
        }
        if (characterNumber == 2)
        {
            cameraTim.transform.parent = null;
        }
        if (characterNumber == 3)
        {
            cameraDoo.transform.parent = null;
        }
        if (characterNumber == 4)
        {
            cameraCla.transform.parent = null;
        }
        if (characterNumber == 5)
        {
            cameraBos.transform.parent = null;
        }
        StartCoroutine(EndManhole());
    }

    IEnumerator EndManhole()
    {
        yield return new WaitForSeconds(1);
        inManhole = false;
    }

}
