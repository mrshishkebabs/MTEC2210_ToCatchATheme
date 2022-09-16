using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject itemPrefab;
    public Transform leftTran;
    public Transform rightTran;
    void Start()
    {

        InvokeRepeating("SpawnItem",0,2); //how long to wait, how long it happen afterwards

    }

    void Update()
    {
        
    }


    public void SpawnItem()
    {
    float rndXValue = Random.Range(leftTran.position.x, rightTran.position.x);

    Vector2 spawnPos = new Vector2(rndXValue, leftTran.position.y);

    Instantiate(itemPrefab, spawnPos, Quaternion.identity); //Vector3.zero means center
    }
}