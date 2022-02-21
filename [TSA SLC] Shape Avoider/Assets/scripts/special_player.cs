using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class special_player : MonoBehaviour
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
        GameObject spawner = GameObject.Find("special_spawner");
        if (spawner.GetComponent<special_spawner>().score > scoreToPass)
        {
            Invoke("complete", delay2);
            colliderenabled = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            restartmenu.SetActive(false);
            Invoke("Restart", delay);
        }
        if(Input.GetKeyDown(KeyCode.LeftAlt))
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (colliderenabled)
        {
            restartmenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameObject sspawner = GameObject.Find("special_spawner");
        sspawner.GetComponent<special_spawner>().score = 0f;
    }    
}