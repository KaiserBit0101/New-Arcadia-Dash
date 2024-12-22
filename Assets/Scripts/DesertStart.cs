using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertStart : MonoBehaviour
{

    void Start()
    {
        this.gameObject.GetComponent<Animator>().Play("Standard Run");
    }

}
