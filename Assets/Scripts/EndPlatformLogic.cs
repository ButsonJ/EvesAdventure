using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatformLogic : MonoBehaviour
{
    [SerializeField] private AudioClip m_clip;
    //[SerializeField] private GameObject toChange;
    [SerializeField] private Material oldColor;
    [SerializeField] private Material newColor;



    //private Renderer render;


    private void Start()
    {
        //used to change color of block... easier to just delete it for time being.
        //render = GetComponent<Renderer>();
        //render.enabled = true;
        //render.sharedMaterial = oldColor;
    }
    public void OnCollisionEnter(Collision other)
    {
         SoundController.Instance.Brodcast(m_clip);


        HL tl = (other.collider.gameObject.GetComponent<HL>());
        if (tl != null)
        {
            SoundController.Instance.Brodcast(m_clip);
            //render.sharedMaterial = newColor;
            Destroy(this.gameObject);
        }


    }

}
