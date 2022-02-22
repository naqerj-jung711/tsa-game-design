using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comp : MonoBehaviour
{
    public Animator transition;
    public float waittime = 1f;

    public void next()
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
