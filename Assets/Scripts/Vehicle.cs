using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private float carSpeed;
    private float startTime;
    [SerializeField] private AudioClip m_clip;


    private void Start()
    {
        startTime = Time.timeSinceLevelLoad;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * carSpeed * Time.deltaTime);
        if ((Time.timeSinceLevelLoad - startTime) > 19)
        {
            Destroy(this.gameObject);

        }
    }

    public void OnCollisionEnter(Collision other)
    {

        HL tl = (other.collider.gameObject.GetComponent<HL>());
        if (tl != null)
        {
            SoundController.Instance.Brodcast(m_clip);
        }


    }
}
