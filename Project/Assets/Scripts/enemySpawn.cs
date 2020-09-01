using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject[] enemies;
    int enemyNo;
    public float maxPosition = 1.56f;
    public float delayTimer = 1f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Vector3 enemyPosition = new Vector3(UnityEngine.Random.Range(-1.56f, 1.56f), transform.position.y, transform.position.z);
            enemyNo = UnityEngine.Random.Range(0, 6);
            Instantiate(enemies[enemyNo], enemyPosition, transform.rotation);
            timer = delayTimer;
        }

        if(timer <= -5)
        {
            delayTimer = delayTimer - 0.3f;
        }
    }
}
    