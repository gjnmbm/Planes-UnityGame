using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private Vector3 spawnPoint;
    public GameObject enemy;
    private float startTimeBtwSpawn;
    private float timeBtwSpawn;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.position;
        InvokeRepeating("ChangePosition", 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            startTimeBtwSpawn = Random.Range(0, 5);
            timeBtwSpawn = startTimeBtwSpawn;
            Instantiate(enemy, transform.position, transform.rotation);
            ChangePosition();
        }
        else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }

    void ChangePosition() {
        transform.position = spawnPoint;
        spawnPoint = new Vector3(transform.position.x, Random.Range(-4, 4), transform.position.z);
    }
}
