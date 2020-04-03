using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public float minSpawnTime;
    public float maxSpawnTime;
    float timeLeft = 0f;
    public GameObject[] clouds;
    public GameObject planet;

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0)
        {
            timeLeft = Random.Range(minSpawnTime, maxSpawnTime);

            int randCloud = Random.Range(0, 4);
            GameObject cloud = clouds[randCloud];
            float randHeight = Random.Range(planet.transform.position.y + 500f, planet.transform.position.y - 500f);
            Vector3 spawnLoc = new Vector3(planet.transform.position.x + 1000, randHeight, 0);
            cloud.transform.position = new Vector3(planet.transform.position.x + 1000, randHeight, 0);
            Instantiate(cloud, transform);
        }
    }
}
