using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{

    [SerializeField] private GameObject car;
    [SerializeField] private Transform spawn;
    private float timSinceLast = 0f;
    [SerializeField] private int spawnTime;


    void Start()
    {
        Spawn();
        
    }

    void Spawn()
    {
        timSinceLast = Time.timeSinceLevelLoad;
        Instantiate(car, spawn.position, Quaternion.identity);

    }
    void Update()
    {


        if (Time.timeSinceLevelLoad >= timSinceLast + spawnTime)
        {
            Spawn();
        }
        

    }

}
