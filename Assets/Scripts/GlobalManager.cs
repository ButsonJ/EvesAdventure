using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{

    public static GlobalManager Instance;
    public int Score;
    [SerializeField] private TextMeshProUGUI scoreTxt;
    [SerializeField] public TextMeshProUGUI endTxt;
    [SerializeField] private TextMeshProUGUI time;
    [SerializeField] private AudioClip winSound;
    [SerializeField] private AudioClip loseSound;


    public GameObject endPanel;
    public int maxTime;

    // Start is called before the first frame update
    void Start()
    {
        maxTime = 120;
        Score = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if(Score == null)
        {
            Score = 0;
        }
        if(endPanel != null)
        {
            if(Score >= 500)
            {
                endTxt.text = "Game Over \nYou Beat Clasic Mode";
                endPanel.SetActive(true);
                SoundController.Instance.Brodcast(winSound);

            }
            if (!endPanel.active)
            {
                time.text = (maxTime - UnityEngine.Time.timeSinceLevelLoad).ToString("0.##");

                scoreTxt.text = "Score : " + (Score).ToString();
                

            }
            if (UnityEngine.Time.timeSinceLevelLoad > maxTime)
            {
                endPanel.SetActive(true);
                SoundController.Instance.Brodcast(loseSound);

            }
        }
        
            


    }
}
