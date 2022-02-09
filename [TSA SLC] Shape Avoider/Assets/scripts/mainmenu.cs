using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("squarelevel");
    }

    public void quit()
    {
        Application.Quit();
        //Debug.Log("quit");
    }
}
