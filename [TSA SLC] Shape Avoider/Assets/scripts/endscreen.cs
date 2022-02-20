using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endscreen : MonoBehaviour
{
    public void quitgame()
    {
        Application.Quit();
    }
    public void quittostart()
    {
        SceneManager.LoadScene("startscreen");
    }    
}
