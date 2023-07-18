using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawn : MonoBehaviour
{
    [SerializeField] private GameObject log;
    [SerializeField] private Transform spawn;
    private float timSinceLast = 0f;
    [SerializeField] private int spawnTime;


    // Start is called before the first frame update
    void Start()
    {
        Spawn();

    }
    void Spawn()
    {
        timSinceLast = Time.timeSinceLevelLoad;
        Instantiate(log, spawn.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= timSinceLast + spawnTime)
        {
            Spawn();
        }
    }
}
