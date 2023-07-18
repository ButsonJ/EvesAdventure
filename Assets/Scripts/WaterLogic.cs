using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaterLogic : MonoBehaviour
{
    [SerializeField] private AudioClip m_clip;
    public GameObject endPanel;
    public bool onWater;
    public GameObject holder;
    [SerializeField] private HL hero;

    [SerializeField] public TextMeshProUGUI endTxt;


    private void Start()
    {
        onWater = false;
    }

    private void Update()
    {
        //I am not able to find a way to get the player to be noticed both on the log and in the water
        //Here I am trying to see if the player is moving, if not I would end the game as that means
        //they are not on a log, It does not work.
        //Still working on this part.

        //if (onWater)
        //{
        //    if (holder.GetComponent<Rigidbody>().velocity.magnitude <= 0.02)
        //    {
        //        SoundController.Instance.Brodcast(m_clip);
        //        Debug.Log("Water entry : " + onWater);
        //        endTxt.text = " Game over, \n fallen in river \n You lose!";
        //        endPanel.SetActive(true);
        //        onWater = false;
        //    }
        //}
    }

    void OnTriggerStay(Collider Other)
    {
        if (Other.name == "Idle (2) Variant")
        {

            onWater = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Water entry : " + onWater);

        if (other.name == "Idle (2) Variant")
        {
            if (!hero.onLog)
            {
                Debug.Log("pudggy");

                //sGlobalManager.endTxt.text = "Game over, You lose!";
                endPanel.SetActive(true);

                holder = other.gameObject;

            }

        }
    }

    //SoundController.Instance.Brodcast(m_clip);
    //Debug.Log("watter entered : " + onWater);


}


