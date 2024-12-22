using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideEnable : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ObjectCollision>().enabled = true;
    }
}
