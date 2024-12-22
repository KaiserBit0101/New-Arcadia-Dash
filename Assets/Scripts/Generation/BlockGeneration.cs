using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGeneration : MonoBehaviour
{
    public GameObject[] blockSection;
    public int numberGen;
    public int zPos = 0;
    public GameObject mousePlay;
    public GameObject timPlay;
    public GameObject doozPlay;
    public GameObject clairePlay;
    public GameObject theBossPlay;
    public GameObject fakeCam;
    public int pickChar;
    public bool generatingBlock = false;

    void Start()
    {
        pickChar = Random.Range(1, 6); //change to 6 for all
        //pickChar = StageSelect.charPlayingAs;
        if (pickChar == 0)
        {
            mousePlay.SetActive(true);
        }
        if (pickChar == 1)
        {
            mousePlay.SetActive(true);
        }
        if (pickChar == 2)
        {
            timPlay.SetActive(true);
        }
        if (pickChar == 3)
        {
            doozPlay.SetActive(true);
        }
        if (pickChar == 4)
        {
            clairePlay.SetActive(true);
        }
        if (pickChar == 5)
        {
            theBossPlay.SetActive(true);
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
