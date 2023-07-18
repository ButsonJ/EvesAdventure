using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwichScene : MonoBehaviour
{

    public void play(string sName)
    {
        if(sName != "Quit")
        {
            SceneManager.LoadScene(sName);

        }
        if(sName == "Quit")
        {
            Application.Quit();
        }
    }

    // returns users to home scene by the name of the home scence SampleScene
    public void home()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
