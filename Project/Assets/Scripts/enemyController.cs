using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    public float speed;
    float goalSpeed1 = -5;
    float goalSpeed2 = -7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);

        if (Time.time >= 15 && speed > goalSpeed1)
        {
            speed -= 2;
        }

        if (Time.time >= 30 && speed > goalSpeed2)
        {
            speed -= 2;
        }

        if (transform.position.y <= -7)
        {
            Destroy(gameObject);
        }
    }
}
