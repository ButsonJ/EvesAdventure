using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    [SerializeField] private AudioClip m_clip;
    public void OnCollisionEnter(Collision other)
    {
       // SoundController.Instance.Brodcast(m_clip);


        HL tl = (other.collider.gameObject.GetComponent<HL>());
        if (tl != null)
        {
            SoundController.Instance.Brodcast(m_clip);
            Destroy(this.gameObject);

        }


    }

}
