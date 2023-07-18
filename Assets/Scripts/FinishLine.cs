using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private AudioClip m_clip;
    public void OnCollisionEnter(Collision other)
    {


        HL tl = (other.collider.gameObject.GetComponent<HL>());
        if (tl != null)
        {
            SoundController.Instance.Brodcast(m_clip);
        }


    }
}
