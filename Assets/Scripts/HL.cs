using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HL : MonoBehaviour
{
    public Animator anim;


    public GameObject endPanel;
    public GameObject  hero;
    public TextMeshProUGUI endTxt;
    public GlobalManager globalManager;
    private Vector3 startPosision;
    public bool onLog;

    void Start()
    {
        startPosision = hero.transform.position;
        onLog = false;
    }


    public void OnCollisionEnter(Collision other)
    {

        Vehicle tl = (other.collider.gameObject.GetComponent<Vehicle>());
        if (tl != null)
        {
            endTxt.text = "Game Over \nHit by a car\nYou Lose!";
            endPanel.SetActive(true);
        }

        WaterLogic wl = (other.collider.gameObject.GetComponent<WaterLogic>());
        if (wl != null)
        {
            if (!onLog)
            {
                endTxt.text = "Game Over \nYou Drowned\nYou Lose!";
                endPanel.SetActive(true);
            }
        }

        CoinLogic cl = (other.collider.gameObject.GetComponent<CoinLogic>());
        if (cl != null)
        {

            globalManager.Score += 10;
        }

        EndPlatformLogic el = (other.collider.gameObject.GetComponent<EndPlatformLogic>());
        if (el != null)
        {

            globalManager.Score += 100;
            hero.transform.position = startPosision;

        }

        FinishLine fl = (other.collider.gameObject.GetComponent<FinishLine>());
        if (fl != null)
        {
            endTxt.text = "Game Over \nYou win!";
            anim.SetTrigger("win");
            endPanel.SetActive(true);
        }

    }
}
