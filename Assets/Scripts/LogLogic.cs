using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogLogic : MonoBehaviour
{
    [SerializeField] private float logSpeed;
    private float startTime;
    [SerializeField]  private  HL hero;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * logSpeed * Time.deltaTime);
        if ((Time.timeSinceLevelLoad - startTime) > 19)
        {
            Destroy(this.gameObject);

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Idle (2) Variant") {
            other.transform.SetParent(transform);
            hero.onLog = true;
            Debug.Log("Water entry : " + hero.onLog);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
        hero.onLog = false;


    }
}
