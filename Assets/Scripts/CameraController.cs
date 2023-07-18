using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform player;
    public float speedSmooth = 0.25f;
    public Vector3 cameraDistance;

    void LateUpdate()
    {
        transform.position = player.position  + cameraDistance;   

        
    }
}
