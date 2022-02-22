using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openinf : MonoBehaviour
{
    public Animator transition;
    public bool l0, l1, l2, l3, l4 = false;
    public float waittime;

    public void level()
    {
        l0 = true;
    }
    public void level1()
    {
        l1 = true;
    }
    public void level2()
    {
        l2 = true;
    }
    public void level3()
    {
        l3 = true;
    }
    public void level4()
    {
        l4 = true;
    }
    void Update()
    {
        if (l0)
        {
            LoadNext0();
        }
        if (l1)
        {
            LoadNext1();
        }
        if (l2)
        {
            LoadNext2();
        }
        if (l3)
        {
            LoadNext3();
        }
        if (l4)
        {
            LoadNext4();
        }
    }

    public void LoadNext0()
    {
        StartCoroutine(LoadLevel(7));
    }
    public void LoadNext1()
    {
        StartCoroutine(LoadLevel(8));
    }
    public void LoadNext2()
    {
        StartCoroutine(LoadLevel(9));
    }
    public void LoadNext3()
    {
        StartCoroutine(LoadLevel(10));
    }
    public void LoadNext4()
    {
        StartCoroutine(LoadLevel(11));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("circlewipe");
        yield return new WaitForSeconds(waittime);
        SceneManager.LoadScene(levelIndex);
    }
}
