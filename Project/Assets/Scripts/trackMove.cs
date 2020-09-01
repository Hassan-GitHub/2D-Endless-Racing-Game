using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class trackMove : MonoBehaviour
{
    public float speed;
    Vector2 offset;
    float goalSpeed1 = 0.65f;
    float goalSpeed2 = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;

        if (Time.time >= 15 && speed < goalSpeed1)
        {
            speed += 0.15f;
        }

        if (Time.time >= 30 && speed < goalSpeed2)
        {
            speed += 0.15f;
        }
    }
}