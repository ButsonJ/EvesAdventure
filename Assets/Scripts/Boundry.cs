using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Boundry : MonoBehaviour
{



    public GameObject endPanel;
    public TextMeshProUGUI endTxt;
    [SerializeField] private AudioClip m_clip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Idle (2) Variant")
        {
            endTxt.text = "Game Over!\nYou went out of bounds";
            endPanel.SetActive(true);
            SoundController.Instance.Brodcast(m_clip);

        }
    }
   
}
