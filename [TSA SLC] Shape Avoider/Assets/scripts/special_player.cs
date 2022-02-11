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
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        GameObject spawner = GameObject.Find("special_spawner");
        if (spawner.GetComponent<special_spawner>().score > scoreToPass)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameObject sspawner = GameObject.Find("special_spawner");
        sspawner.GetComponent<special_spawner>().score = 0f;
    }
}