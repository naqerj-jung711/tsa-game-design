using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pausemenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                resume();
            } else
            {
                paused();
            }
        }
    }
    public void resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void paused()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void menu()
    {
        Time.timeScale = 1f;
        isPaused = false;
        SceneManager.LoadScene("startscreen");
    }
}
