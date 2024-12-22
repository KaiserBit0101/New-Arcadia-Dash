using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertGeneration : MonoBehaviour
{
    public GameObject[] blockSection;
    public int numberGen;
    public int zPos = 0;
    
    public GameObject doozPlay;
    
    public GameObject fakeCam;
    public int pickChar;
    public bool generatingBlock = false;

    void Start()
    {
        
        //pickChar = Random.Range(1, 6); //change to 6 for all


        if (pickChar == 0)
        {
            doozPlay.SetActive(true);
        }
       
        fakeCam.SetActive(false);
        numberGen = Random.Range(0, 10);
        blockSection[numberGen].SetActive(true);
        Instantiate(blockSection[numberGen], new Vector3(0, 0, zPos), Quaternion.identity);
        blockSection[numberGen].SetActive(false);
        zPos += 200;
    }

    void OnTriggerEnter(Collider other)
    {
        if (generatingBlock == false)
        {
            generatingBlock = true;
            StartCoroutine(GenerateNext());
        }
    }


    IEnumerator GenerateNext()
    {
        yield return new WaitForSeconds(1);
        numberGen = Random.Range(0, 10);
        blockSection[numberGen].SetActive(true);
        Instantiate(blockSection[numberGen], new Vector3(0, 0, zPos), Quaternion.identity);
        blockSection[numberGen].SetActive(false);
        zPos += 200;
        transform.position = new Vector3(0, 3, zPos - 200);
        generatingBlock = false;
    }

}
