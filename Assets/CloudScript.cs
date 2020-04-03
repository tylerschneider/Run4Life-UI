using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    float speed;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }
    void Update()
    {
        transform.position += Vector3.left * speed;

        if(transform.position.x < -400)
        {
            Destroy(this.gameObject);
        }
    }
}
