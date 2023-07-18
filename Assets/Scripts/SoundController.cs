using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController Instance;
    [SerializeField] private AudioSource m_effectsSource;

    void Awake()
    {
        //validating that only one sound is playing --Singleton
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Brodcast(AudioClip audio)
    {
        m_effectsSource.PlayOneShot(audio);
    }
}
