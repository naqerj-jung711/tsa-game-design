using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fade : MonoBehaviour
{
    public bool yes = false;
    public Animator transition;
    public float waittime;

    // Update is called once per frame
    void Update()
    {
        if (yes)
        {
            LoadNext();
        }    
     
    }
    public void Set()
    {
        yes = true;
    }

    public void LoadNext()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    } 
    
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("circlewipe");
        yield return new WaitForSeconds(waittime);
        SceneManager.LoadScene(levelIndex);
    }
}
