using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float vehicleSpeed;
    public float maxPosition;

    Vector3 position;
    public uiManager ui;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * vehicleSpeed * Time.deltaTime;

        position.x = Mathf.Clamp(position.x, -1.56f, 1.56f);

        transform.position = position;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            ui.gameOverActivated();
        }
    }
}
