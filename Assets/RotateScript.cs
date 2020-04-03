using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
