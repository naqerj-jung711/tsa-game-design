using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    public score_value score;
    public float moveSpeed = 600f;
    float movement = 0f;
    public float scoreToPass = 50f;
    public float delay = 0.1f;
    public float delay2 = 0.1f;
    public GameObject restartmenu;
    public GameObject completemenu;
    public bool colliderenabled = true;
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        GameObject spawner = GameObject.Find("spawner");
        if(spawner.GetComponent<spawner>().score > scoreToPass)
        {
            Invoke("complete", delay2);
            colliderenabled = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            restartmenu.SetActive(false);
            Time.timeScale = 1f;
            Invoke("Restart", delay);
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            colliderenabled = false;
        }
    }
    void complete()
    {
        completemenu.SetActive(true);
    }    
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(colliderenabled)
        {
            restartmenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameObject spawner = GameObject.Find("spawner");
        spawner.GetComponent<spawner>().score = 0f;
    }    
}